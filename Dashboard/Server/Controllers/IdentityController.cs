using Dashboard.Functions.Notifications.SendBug;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared.Identity;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers;

[Route("auth")]
[ApiController]
public class IdentityController : ControllerBase
{
    public record UserQuery(string username, string password);

    private readonly IIdentityService identityService;
    private readonly IMediator mediator;

    public IdentityController(IMediator mediator, IIdentityService identityService)
    {
        this.identityService = identityService;
        this.mediator = mediator;
    }


    [Route("login")]
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Login([FromBody] UserQuery user)
    {
        try
        {
            var retVal = await identityService.Login(user.username, user.password);
            if (retVal.Succeeded)
                return Ok(retVal.RetVal);
            else
                return NotFound(retVal.ErrorToString());
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }
    [Route("logout")]
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Logout()
    {
        try
        {
            var accessToken = await HttpContext.GetTokenAsync("Bearer", "access_token");
            await identityService.Logout(HttpContext.User.Identity?.Name, accessToken);
            return Ok();
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [Route("refresh")]
    [HttpPost]
    [AllowAnonymous]
    public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequest request)
    {
        try
        {
            var retVal = await identityService.RefreshToken(request);
            if (retVal.Succeeded)
                return Ok(retVal.RetVal);
            else
                return BadRequest(retVal.ErrorToString());
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }
}
