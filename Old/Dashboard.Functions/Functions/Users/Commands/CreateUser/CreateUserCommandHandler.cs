using Dashboard.Infrastructure.Entity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Identity;

namespace Dashboard.Functions.Functions.Users.Commands.CreateUser;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Result>
{
    private readonly UserManager<UserEntity> userManager;
    private readonly IMapper mapper;

    public CreateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper)
    {
        this.userManager = userManager;
        this.mapper = mapper;
    }
    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = mapper.Map<UserEntity>(request.UserCreate);
        var result = await userManager.CreateAsync(user);
        if (!result.Succeeded)
            return Result.Failed(mapper.Map<string[]>(result));

        return Result.Success;
    }
}
