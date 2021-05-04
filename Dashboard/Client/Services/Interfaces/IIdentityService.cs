using Microsoft.AspNetCore.Components.Authorization;
using System.Threading.Tasks;

namespace Dashboard.Client.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<AuthenticationState> GetAuthState();
        Task Login(string username, string password);
        Task Logout();
    }
}
