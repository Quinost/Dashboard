using Dashboard.Client.Authentication;
using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Dashboard.Shared.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly JwtStateProvider authProvider;
        private readonly HttpClient httpClient;

        public IdentityService(JwtStateProvider _authProvider, HttpClient _httpClient)
        {
            authProvider = _authProvider;
            httpClient = _httpClient;
        }

        public async Task Login(string username, string password)
        {
            var retVal = await httpClient.PostAsJsonAsync("auth/login", new { username = username, password = password });
            if (!retVal.IsSuccessStatusCode)
            {
                throw new Exception(await retVal.Content.ReadAsStringAsync());
            }
            var token = await retVal.Content.ReadFromJsonAsync<TokenResult>();
            await authProvider.LoginToken(token);
        }

        public async Task Logout()
        {
            await httpClient.PostAsync("auth/logout", null);
            await authProvider.LogoutToken();
        }
        public async Task<AuthenticationState> GetAuthState()
            => await authProvider.GetAuthenticationStateAsync();
    }
}
