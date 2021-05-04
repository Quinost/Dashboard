using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Dashboard.Shared.Identity;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class TokenProvider : ITokenProvider
    {
        private record RefreshToken(string refreshToken, DateTime refreshTokenExpiry);
        private readonly IJSRuntime jsRuntime;

        public TokenProvider(IJSRuntime _jsRuntime) 
            => jsRuntime = _jsRuntime;

        public async Task<string> GetAccessToken()
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

        public async Task<string> GetRefreshToken()
        {
            var jsonToken = await jsRuntime.InvokeAsync<string>("localStorage.getItem", "refreshToken");
            if (!string.IsNullOrWhiteSpace(jsonToken))
            {
                var refToken = JsonSerializer.Deserialize<RefreshToken>(jsonToken);
                if (DateTime.UtcNow > refToken.refreshTokenExpiry)
                    return refToken.refreshToken;
                else
                    await RemoveToken();
            }
            return default;
        }

        public async ValueTask SetToken(TokenResult token)
        {
            var refToken = new RefreshToken(token.RefreshToken, token.RefreshTokenExpiry);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "authToken", token.AccessToken);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "refreshToken", JsonSerializer.Serialize(refToken));
        }

        public async ValueTask RemoveToken()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "authToken");
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "refreshToken");
        }

        public async Task<IEnumerable<Claim>> GetParsedClaimsFromToken()
        {
            var token = await GetAccessToken();
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
