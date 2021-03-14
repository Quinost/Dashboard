using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Threading.Tasks;

namespace Dashboard.Client.Authentication
{
    public class AuthStateProvider : AuthenticationStateProvider
    {

        public AuthStateProvider()
        {
            //TODO: Add Auth
        }
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
