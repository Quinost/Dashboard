using Dashboard.Shared;

namespace Dashboard.Functions.Functions.Users.Commands.CreateRole;
public class CreateRoleCommand : IRequest<Result>
{
    public CreateRoleCommand(string roleName) 
        => RoleName = roleName;

    public string RoleName { get; }
}
