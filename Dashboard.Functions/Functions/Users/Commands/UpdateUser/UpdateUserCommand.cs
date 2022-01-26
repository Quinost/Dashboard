namespace Dashboard.Functions.Functions.Users.Commands.UpdateUser;
public class UpdateUserCommand : IRequest<ResultFunction>
{
    public UpdateUserCommand(UserUpdate userUpdate)
    {
        UserUpdate = userUpdate;
    }
    public UserUpdate UserUpdate { get; }
}
