using Dashboard.Infrastructure;
using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Models;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Server.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext context;
        private readonly UserManager<UserEntity> userManager;

        public UserService(DataContext _context, UserManager<UserEntity> _userManager)
        {
            context = _context;
            userManager = _userManager;
        }

        public async Task<Result<IEnumerable<UserModel>>> GetUsers()
        {
            var users = (await context.Users.ToListAsync()).ToUserModelList();
            return Result<IEnumerable<UserModel>>.Success(users);
        }
        public async Task<Result> UpdateUser(UserModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id.ToString());
            if (user is null)
                return Result.Failed("Can't find user");

            user = model.ToUserEntity();

            var result = await userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return Result.Failed(result.ToErrorsString());

            return Result.Success;
        }

        public async Task<Result> AddUser(UserModel model)
        {
            var result = await userManager.CreateAsync(model.ToUserEntity());
            if (!result.Succeeded)
                return Result.Failed(result.ToErrorsString());

            return Result.Success;
        }

        public async Task<Result<IEnumerable<RoleModel>>> GetRoles()
        {
            var roles = (await context.Roles.ToListAsync()).ToRoleModel();
            return Result<IEnumerable<RoleModel>>.Success(roles);
        }
    }
}
