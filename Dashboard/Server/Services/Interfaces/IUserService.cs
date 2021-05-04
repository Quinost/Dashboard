using Dashboard.Server.Models;
using Dashboard.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Interfaces
{
    public interface IUserService
    {
        Task<Result<IEnumerable<UserModel>>> GetUsers();
        Task<Result> UpdateUser(UserModel model);
        Task<Result> AddUser(UserModel model);
        Task<Result<IEnumerable<RoleModel>>> GetRoles();
    }
}
