﻿using Dashboard.Shared;

namespace Dashboard.Functions.Functions.Users.Commands.UpdateUser;
public class UpdateUserCommand : IRequest<Result>
{
    public UpdateUserCommand(UserUpdate userUpdate)
    {
        UserUpdate = userUpdate;
    }
    public UserUpdate UserUpdate { get; }
}
