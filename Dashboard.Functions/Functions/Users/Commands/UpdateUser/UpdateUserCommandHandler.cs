using Dashboard.Infrastructure.Entity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;

namespace Dashboard.Functions.Functions.Users.Commands.UpdateUser;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Result>
{
    private readonly UserManager<UserEntity> userManager;
    private readonly IMapper mapper;

    public UpdateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper)
    {
        this.userManager = userManager;
        this.mapper = mapper;
    }
    public async Task<Result> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.UserUpdate.Id.ToString());
        if (user is null)
            return Result.Failed("Can't find user");

        user = mapper.Map<UserEntity>(request.UserUpdate);

        var result = await userManager.UpdateAsync(user);

        if (!result.Succeeded)
            return Result.Failed(mapper.Map<string[]>(result));

        return Result.Success;
    }
}
