namespace Dashboard.Functions.Functions.Users.Commands.CreateUser;
public class CreateUserCommand : IRequest<ResultFunction>
{
    public CreateUserCommand(UserCreate userCreate)
        => UserCreate = userCreate;

    public UserCreate UserCreate { get; }
}
