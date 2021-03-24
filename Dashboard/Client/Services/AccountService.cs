using Dashboard.Client.Authentication;
using Dashboard.Shared;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Dashboard.Client.Services
{
    public class AccountService
    {
        private readonly JwtStateProvider authProvider;
        private readonly HttpClient httpClient;

        public AccountService(JwtStateProvider _authProvider, HttpClient _httpClient)
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
            var model = await retVal.Content.ReadFromJsonAsync<TokenModel>();
            await authProvider.LoginToken(model.Token, model.Expiration);
        }

        public async Task Logout()
            => await authProvider.LogoutToken();

        public async Task<AuthenticationState> GetAuthState()
            => await authProvider.GetAuthenticationStateAsync();

        public async Task<string> GetToken()
            => await authProvider.GetToken();
    }
}
