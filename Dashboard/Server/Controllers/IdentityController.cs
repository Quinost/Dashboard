using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Dashboard.Shared.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Controllers
{
    [Route("auth")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        public record UserQuery(string username, string password);

        private readonly IBugService bugService;
        private readonly IIdentityService identityService;

        public IdentityController(IBugService _bugService, IIdentityService _identityService)
        {
            bugService = _bugService;
            identityService = _identityService;
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
                await bugService.SaveBug(ex.Message, "CORE API");
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
                await identityService.Logout(HttpContext.User.Identity?.Name);
                return Ok();
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API");
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
                await bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }
    }
}
