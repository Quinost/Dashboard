using Dashboard.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;

namespace Dashboard.Functions.Functions.Users.Commands.UpdateUser;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, ResultFunction>
{
    private readonly UserManager<UserEntity> userManager;
    private readonly IMapper mapper;

    public UpdateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper)
    {
        this.userManager = userManager;
        this.mapper = mapper;
    }
    public async Task<ResultFunction> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        var user = await userManager.FindByIdAsync(request.UserUpdate.Id.ToString());
        if (user is null)
            return ResultFunction.Failed("Can't find user");

        user = mapper.Map<UserEntity>(request.UserUpdate);

        var result = await userManager.UpdateAsync(user);

        if (!result.Succeeded)
            return ResultFunction.Failed(mapper.Map<string[]>(result));

        return ResultFunction.Success;
    }
}
