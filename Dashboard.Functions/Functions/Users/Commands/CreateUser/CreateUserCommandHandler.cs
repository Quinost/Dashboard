using Dashboard.Infrastructure.Entity;
using Microsoft.AspNetCore.Identity;

namespace Dashboard.Functions.Functions.Users.Commands.CreateUser;
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, ResultFunction>
{
    private readonly UserManager<UserEntity> userManager;
    private readonly IMapper mapper;

    public CreateUserCommandHandler(UserManager<UserEntity> userManager, IMapper mapper)
    {
        this.userManager = userManager;
        this.mapper = mapper;
    }
    public async Task<ResultFunction> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = mapper.Map<UserEntity>(request.UserCreate);
        var result = await userManager.CreateAsync(user);
        if (!result.Succeeded)
            return ResultFunction.Failed(mapper.Map<string[]>(result));

        return ResultFunction.Success;
    }
}
