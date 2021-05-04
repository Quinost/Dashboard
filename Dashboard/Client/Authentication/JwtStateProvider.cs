using Dashboard.Client.Services;
using Dashboard.Client.Services.Interfaces;
using Dashboard.Shared;
using Dashboard.Shared.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dashboard.Client.Authentication
{
    public class JwtStateProvider : AuthenticationStateProvider
    {
        private readonly ITokenProvider tokenProvider;

        public JwtStateProvider(ITokenProvider _tokenProvider)
        {
            tokenProvider = _tokenProvider;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var claims = await tokenProvider.GetParsedClaimsFromToken();
            var identity = claims is null ? new ClaimsIdentity() : new ClaimsIdentity(claims, "jwt");
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        public async Task LoginToken(TokenResult token)
        {
            await tokenProvider.SetToken(token);
            var claims = await tokenProvider.GetParsedClaimsFromToken();
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(claims, "jwt"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public async Task LogoutToken()
        {
            await tokenProvider.RemoveToken();
            var authState = Task.FromResult(new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity())));
            NotifyAuthenticationStateChanged(authState);
        }
    }
}
