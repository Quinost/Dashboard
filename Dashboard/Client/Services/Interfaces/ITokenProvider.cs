using Dashboard.Shared.Identity;
using System.Security.Claims;

namespace Dashboard.Client.Services.Interfaces;

public interface ITokenProvider
{
    Task<string> GetAccessToken();
    ValueTask RemoveToken();
    ValueTask SetToken(TokenResult token);
    Task<IEnumerable<Claim>> GetParsedClaimsFromToken();
    Task<string> GetRefreshToken();
}
