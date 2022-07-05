using AutoMapper;
using Dashboard.Functions.Functions.Users.Commands.CreateRole;
using Dashboard.Functions.Functions.Users.Commands.CreateUser;
using Dashboard.Functions.Functions.Users.Commands.UpdateUser;
using Dashboard.Functions.Functions.Users.Queries.GetRoleList;
using Dashboard.Functions.Functions.Users.Queries.GetUserList;
using Dashboard.Functions.Notifications.SendBug;
using Dashboard.Shared;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers;
[Route("api/users")]
[ApiController]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;

    public UsersController(IMediator mediator, IMapper mapper)
    {
        this.mediator = mediator;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        try
        {
            var users = await mediator.Send(new GetUserListQuery());
            return Ok(mapper.Map<IEnumerable<UserModel>>(users));
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpPost]
    public async Task<IActionResult> UpdateUser([FromBody] UserModel user)
    {
        try
        {
            var result = await mediator.Send(new UpdateUserCommand(mapper.Map<UserUpdate>(user)));
            if (result.Succeeded)
                return Ok();
            else
                return BadRequest(result.ErrorToString());
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpPut]
    public async Task<IActionResult> AddUser([FromBody] UserModel user)
    {
        try
        {
            var result = await mediator.Send(new CreateUserCommand(mapper.Map<UserCreate>(user)));
            if (result.Succeeded)
                return Ok();
            else
                return BadRequest(result.ErrorToString());
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpGet]
    [Route("roles")]
    public async Task<IActionResult> GetRoles()
    {
        try
        {
            var result = await mediator.Send(new GetRoleListQuery());
            return Ok(mapper.Map<IEnumerable<RoleModel>>(result));
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpPut]
    [Route("roles")]
    public async Task<IActionResult> SaveRole([FromBody] RoleModel role)
    {
        try
        {
            var result = await mediator.Send(new CreateRoleCommand(role.Name));
            if (result.Succeeded)
                return Ok();
            else
                return BadRequest(result.ErrorToString());
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }
}
