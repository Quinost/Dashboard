using Dashboard.Data;
using Dashboard.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Server.Services.Identity;

public class UserStore : IUserStore<UserEntity>, IUserPasswordStore<UserEntity>, IUserLockoutStore<UserEntity>
{
    private readonly DataContext _context;

    public UserStore(DataContext context)
    {
        _context = context;
    }

    public void Dispose()
        => _context.Dispose();

    public async Task<UserEntity> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        => await _context.Users.AsNoTracking().Include(v => v.Role).FirstOrDefaultAsync(v => v.Username.ToUpper() == normalizedUserName);

    public Task<string> GetPasswordHashAsync(UserEntity user, CancellationToken cancellationToken)
        => Task.FromResult(user.Password);

    public async Task<IdentityResult> UpdateAsync(UserEntity user, CancellationToken cancellationToken)
    {
        try
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return IdentityResult.Success;
        }
        catch (Exception ex)
        {
            return IdentityResult.Failed(new IdentityError() { Code = ex.Message });
        }
    }

    public Task<string> GetUserIdAsync(UserEntity user, CancellationToken cancellationToken)
        => Task.FromResult(user.Id.ToString());

    public Task<string> GetUserNameAsync(UserEntity user, CancellationToken cancellationToken)
        => Task.FromResult(user.Username);

    public Task SetNormalizedUserNameAsync(UserEntity user, string normalizedName, CancellationToken cancellationToken)
        => Task.CompletedTask;

    public async Task<IdentityResult> CreateAsync(UserEntity user, CancellationToken cancellationToken)
    {
        _context.Users.Add(user);
        var res = await _context.SaveChangesAsync();
        if (res != 0)
            return IdentityResult.Success;
        else
            return IdentityResult.Failed(new IdentityError { Code = "Can't create user" });
    }

    public async Task<UserEntity> FindByIdAsync(string userId, CancellationToken cancellationToken)
        => await _context.Users.AsNoTracking().FirstOrDefaultAsync(v => v.Id == Guid.Parse(userId));

    public Task SetPasswordHashAsync(UserEntity user, string passwordHash, CancellationToken cancellationToken)
        => Task.FromResult(user.Password = passwordHash);

    public Task SetUserNameAsync(UserEntity user, string userName, CancellationToken cancellationToken)
        => Task.FromResult(user.Username = userName);

    public Task<DateTimeOffset?> GetLockoutEndDateAsync(UserEntity user, CancellationToken cancellationToken)
        => Task.FromResult<DateTimeOffset?>(DateTimeOffset.UtcNow.AddYears(1));

    public Task<bool> GetLockoutEnabledAsync(UserEntity user, CancellationToken cancellationToken)
        => Task.FromResult(user.IsActive);

    public Task SetLockoutEnabledAsync(UserEntity user, bool enabled, CancellationToken cancellationToken)
        => Task.FromResult(user.IsActive = enabled);

    public Task SetLockoutEndDateAsync(UserEntity user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task<int> IncrementAccessFailedCountAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task ResetAccessFailedCountAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task<int> GetAccessFailedCountAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task<IdentityResult> DeleteAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task<string> GetNormalizedUserNameAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
    public Task<bool> HasPasswordAsync(UserEntity user, CancellationToken cancellationToken)
        => throw new NotImplementedException();
}
