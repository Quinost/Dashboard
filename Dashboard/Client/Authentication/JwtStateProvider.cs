using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Authentication
{
    public class JwtStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime jsRuntime;

        public JwtStateProvider(IJSRuntime _jsRuntime)
        {
            jsRuntime = _jsRuntime;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await GetToken();
            var identity = string.IsNullOrEmpty(token) ? new ClaimsIdentity() : new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        public async ValueTask LoginToken(string token, DateTime expiry)
        {
            await SetToken(token, expiry);
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public async ValueTask LogoutToken()
        {
            await RemoveToken();
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            NotifyAuthenticationStateChanged(authState);
        }

        public async ValueTask<string> GetToken()
        {
            var expiry = await jsRuntime.InvokeAsync<object>("localStorage.getItem", "authTokenExpiry");
            if (expiry != null)
            {
                if (DateTime.Parse(expiry.ToString()) > DateTime.Now)
                    return await jsRuntime.InvokeAsync<string>("localStorage.getItem", "authToken");
                else
                    await RemoveToken();
            }
            return null;
        }

        private async ValueTask SetToken(string token, DateTime expiry)
        {
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "authTokenExpiry", expiry);
            await jsRuntime.InvokeVoidAsync("localStorage.setItem", "authToken", token);
        }

        private async ValueTask RemoveToken()
        {
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "authToken");
            await jsRuntime.InvokeVoidAsync("localStorage.removeItem", "authTokenExpiry");
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
