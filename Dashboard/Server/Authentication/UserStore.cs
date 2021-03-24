using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard.Server.Authentication
{
    public class UserStore : IUserStore<UserModel>, IUserPasswordStore<UserModel>
    {
        public readonly UserModel User;

        public UserStore()
        {
            User = new UserModel
            {
                Id = Guid.NewGuid(),
                Username = "Dashboard"
            };
            User.Password = new PasswordHasher<UserModel>().HashPassword(User, "securePassword");
        }
        public Task<IdentityResult> CreateAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<IdentityResult> DeleteAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public void Dispose()
        {

        }

        public Task<UserModel> FindByIdAsync(string userId, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<UserModel> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            if (normalizedUserName == User.Username.ToUpper())
            {
                return Task.FromResult(User);
            }
            return Task.FromResult<UserModel>(null);
        }

        public Task<string> GetNormalizedUserNameAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<string> GetPasswordHashAsync(UserModel user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Password);
        }

        public Task<string> GetUserIdAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<string> GetUserNameAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<bool> HasPasswordAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task SetNormalizedUserNameAsync(UserModel user, string normalizedName, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task SetPasswordHashAsync(UserModel user, string passwordHash, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task SetUserNameAsync(UserModel user, string userName, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<IdentityResult> UpdateAsync(UserModel user, CancellationToken cancellationToken)
            => throw new NotImplementedException();
    }
}
