using AutoMapper;
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
        private readonly DataContext _context;
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;

        public UserService(DataContext context, UserManager<UserEntity> userManager, IMapper mapper)
        {
            _context = context;
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<Result<IEnumerable<UserModel>>> GetUsers()
        {
            var usersList = await _context.Users.AsNoTracking().ToListAsync();
            var users = _mapper.Map<IEnumerable<UserModel>>(usersList);
            return Result<IEnumerable<UserModel>>.Success(users);
        }
        public async Task<Result> UpdateUser(UserModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id.ToString());
            if (user is null)
                return Result.Failed("Can't find user");

            user = _mapper.Map<UserEntity>(model);

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
                return Result.Failed(_mapper.Map<string[]>(result));

            return Result.Success;
        }

        public async Task<Result> AddUser(UserModel model)
        {
            var user = _mapper.Map<UserEntity>(model);
            var result = await _userManager.CreateAsync(user);
            if (!result.Succeeded)
                return Result.Failed(_mapper.Map<string[]>(result));

            return Result.Success;
        }

        public async Task<Result<IEnumerable<RoleModel>>> GetRoles()
        {
            var rolesList = await _context.Roles.ToListAsync();
            var roles = _mapper.Map<IEnumerable<RoleModel>>(rolesList);
            return Result<IEnumerable<RoleModel>>.Success(roles);
        }

        public async Task<Result> AddRole(string name)
        {
            var role = await _context.Roles.FirstOrDefaultAsync(v => v.Name.ToLower() == name.ToLower());
            if (role is not null)
                return Result.Failed($"Role {name} exist");

            _context.Roles.Add(new RoleEntity { Name = name });
            await _context.SaveChangesAsync();
            return Result.Success;
        }
    }
}
