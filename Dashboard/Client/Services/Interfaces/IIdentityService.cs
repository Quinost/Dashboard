using Microsoft.AspNetCore.Components.Authorization;

namespace Dashboard.Client.Services.Interfaces;

public interface IIdentityService
{
    Task<AuthenticationState> GetAuthState();
    Task Login(string username, string password);
    Task Logout();
}
