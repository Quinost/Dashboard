using Dashboard.Shared;
using Dashboard.Shared.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Dashboard.Client.Services.Interfaces
{
    public interface ITokenProvider
    {
        Task<string> GetAccessToken();
        ValueTask RemoveToken();
        ValueTask SetToken(TokenResult token);
        Task<IEnumerable<Claim>> GetParsedClaimsFromToken();
        Task<string> GetRefreshToken();
    }
}
