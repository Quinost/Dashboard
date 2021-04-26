using Dashboard.Shared;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public interface ITokenProvider
    {
        Task<string> GetToken();
        ValueTask RemoveToken();
        ValueTask SetToken(TokenResult token);
        Task<IEnumerable<Claim>> GetParsedClaimsFromToken();
    }
    public class TokenProvider : ITokenProvider
    {
        private readonly IJSRuntime jsRuntime;

        public TokenProvider(IJSRuntime _jsRuntime) 
            => jsRuntime = _jsRuntime;

        public async Task<string> GetToken()
        {
            var token = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "authToken");
            if (!string.IsNullOrWhiteSpace(token))
            {
                var expiry = long.Parse(ParseClaimsFromJwt(token).FirstOrDefault(v => v.Type == "exp").Value + "000");
                if (DateTimeOffset.FromUnixTimeMilliseconds(expiry).UtcDateTime > DateTime.UtcNow)
                    return token;
                else
                    await RemoveToken();
            }
            return null;
        }

        public async ValueTask SetToken(TokenResult token)
        {
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "authToken", token.AccessToken);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "refreshToken", token.RefreshToken);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "refreshTokenExpiry", token.RefreshTokenExpiry);
        }

        public async ValueTask RemoveToken()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "authToken");
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "refreshToken");
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "refreshTokenExpiry");
        }

        public async Task<IEnumerable<Claim>> GetParsedClaimsFromToken()
        {
            var token = await GetToken();
            if (string.IsNullOrEmpty(token))
                return default;
            return ParseClaimsFromJwt(token);
        }


        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
