using Dashboard.Infrastructure;
using Dashboard.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dashboard.Server.Services.Identity
{
    public class UserStore : IUserStore<UserEntity>, IUserPasswordStore<UserEntity>
    {
        private readonly DataContext context;

        public UserStore(DataContext _context)
        {
            context = _context;
        }

        public void Dispose()
            => context.Dispose();

        public async Task<UserEntity> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken) 
            => await context.Users.FirstOrDefaultAsync(v => v.Username.ToUpper() == normalizedUserName);

        public Task<string> GetPasswordHashAsync(UserEntity user, CancellationToken cancellationToken) 
            => Task.FromResult(user.Password);

        public async Task<IdentityResult> UpdateAsync(UserEntity user, CancellationToken cancellationToken)
        {
            try
            {
                context.Users.Update(user);
                await context.SaveChangesAsync();
                return IdentityResult.Success;
            }
            catch(Exception ex)
            {
                return IdentityResult.Failed(new IdentityError() { Description = ex.Message });
            }     
        }

        public Task<IdentityResult> CreateAsync(UserEntity user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<IdentityResult> DeleteAsync(UserEntity user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<UserEntity> FindByIdAsync(string userId, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<string> GetNormalizedUserNameAsync(UserEntity user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task<string> GetUserIdAsync(UserEntity user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Id.ToString());
        }

        public Task<string> GetUserNameAsync(UserEntity user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Username);
        }

        public Task<bool> HasPasswordAsync(UserEntity user, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task SetNormalizedUserNameAsync(UserEntity user, string normalizedName, CancellationToken cancellationToken)
            => Task.CompletedTask;

        public Task SetPasswordHashAsync(UserEntity user, string passwordHash, CancellationToken cancellationToken)
            => throw new NotImplementedException();

        public Task SetUserNameAsync(UserEntity user, string userName, CancellationToken cancellationToken)
            => throw new NotImplementedException();


        public async Task SetIsActive(UserEntity user, bool isActive)
        {
            user.IsActive = isActive;
            context.Users.Update(user);
            await context.SaveChangesAsync();
        }
    }
}
