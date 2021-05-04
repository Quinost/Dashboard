using Dashboard.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Client.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserModel>> GetUsers();
        Task UpdateUser(UserModel user);
        Task AddUser(UserModel user);
        Task<List<RoleModel>> GetRoles();
    }
}
