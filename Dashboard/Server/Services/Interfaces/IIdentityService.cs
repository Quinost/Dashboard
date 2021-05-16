using Dashboard.Server.Models;
using Dashboard.Shared;
using Dashboard.Shared.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Interfaces
{
    public interface IIdentityService
    {
        Task<Result<TokenResult>> Login(string userName, string password);
        Task<Result> Logout(string userName, string accessToken);
        Task<Result<TokenResult>> RefreshToken(RefreshTokenRequest request);
    }
}
