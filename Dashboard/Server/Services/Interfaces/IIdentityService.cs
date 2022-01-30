using Dashboard.Shared;
using Dashboard.Shared.Identity;

namespace Dashboard.Server.Services.Interfaces;

public interface IIdentityService
{
    Task<Result<TokenResult>> Login(string userName, string password);
    Task<Result> Logout(string userName, string accessToken);
    Task<Result<TokenResult>> RefreshToken(RefreshTokenRequest request);
}
