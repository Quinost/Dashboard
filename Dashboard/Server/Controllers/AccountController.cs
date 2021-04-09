using Dashboard.Server.Authentication.JWT;
using Dashboard.Server.Context.Entity;
using Dashboard.Server.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public record UserQuery(string username, string password);

        private readonly JwtTokenGenerator jwtTokenGenerator;
        private readonly UserManager<UserEntity> userManager;
        private readonly BugService bugService;

        public AccountController(JwtTokenGenerator _jwtTokenGenerator, UserManager<UserEntity> _userManager, BugService _bugService)
        {
            jwtTokenGenerator = _jwtTokenGenerator;
            userManager = _userManager;
            bugService = _bugService;
        }


        [Route("login")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] UserQuery user)
        {
            try
            {
                var userModel = await userManager.FindByNameAsync(user.username);
                if (userModel is null)
                    return NotFound("User not found");

                var checkPassword = await userManager.CheckPasswordAsync(userModel, user.password);
                if (!checkPassword)
                    return NotFound("Wrong login or password");

                var token = jwtTokenGenerator.GenerateToken(userModel.Username);
                return Ok(token);
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(new BugEntity { Message = ex.Message, System = "CORE API" });
                return StatusCode(500);
            }
        }
    }
}
