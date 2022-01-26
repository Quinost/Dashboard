using Dashboard.Infrastructure.Entity;

namespace Dashboard.Functions.Functions.Users.Commands.CreateRole;
public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, ResultFunction>
{
    private readonly DataContext context;

    public CreateRoleCommandHandler(DataContext context) 
        => this.context = context;

    public async Task<ResultFunction> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = await context.Roles.FirstOrDefaultAsync(v => v.Name.ToLower() == request.RoleName.ToLower());
        if (role is not null)
            return ResultFunction.Failed($"Role {request.RoleName} exist");

        context.Roles.Add(new RoleEntity { Name = request.RoleName });
        await context.SaveChangesAsync();
        return ResultFunction.Success;
    }
}
