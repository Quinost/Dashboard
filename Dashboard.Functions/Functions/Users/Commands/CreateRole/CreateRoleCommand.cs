namespace Dashboard.Functions.Functions.Users.Commands.CreateRole;
public class CreateRoleCommand : IRequest<ResultFunction>
{
    public CreateRoleCommand(string roleName) 
        => RoleName = roleName;

    public string RoleName { get; }
}
