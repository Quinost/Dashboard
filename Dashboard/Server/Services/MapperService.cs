using Dashboard.Infrastructure.Entity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Server.Services
{
    public static class MapperService
    {
        public static IEnumerable<BugModel> ToBugModel(this IList<BugEntity> model)
            => model.Select(v => new BugModel { Id = v.Id, Date = v.Date, Message = v.Message, System = v.System });

        public static IEnumerable<UserModel> ToUserModelList(this IList<UserEntity> model)
            => model.Select(v => new UserModel { Id = v.Id, Username = v.Username, PasswordHash = v.Password, IsActive = v.IsActive, RefreshToken = v.RefreshToken, RefreshTokenExpiry = v.RefreshTokenExpiry, RoleId = v.RoleId });

        public static UserEntity ToUserEntity(this UserModel model)
            => new UserEntity { Id = model.Id, IsActive = model.IsActive, Username = model.Username, Password = model.PasswordHash, RefreshToken = model.RefreshToken, RefreshTokenExpiry = model.RefreshTokenExpiry, RoleId = model.RoleId };

        public static IEnumerable<RoleModel> ToRoleModel(this IList<RoleEntity> model)
            => model.Select(v => new RoleModel { Id = v.Id, Name = v.Name });

        public static string ToErrorsString(this IdentityResult model)
            => string.Join(",", model.Errors.Select(x => x.Code).ToList());
    }
}
