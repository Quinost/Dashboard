using Dashboard.Server.Authentication;
using Dashboard.Server.Authentication.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Controllers
{
    [Route("auth")]
    [ApiController]
    [AllowAnonymous]
    public class AccountController : ControllerBase
    {
        public record UserQuery(string username, string password);

        private readonly JwtTokenGenerator jwtTokenGenerator;
        private readonly UserManager<UserModel> userManager;

        public AccountController(JwtTokenGenerator _jwtTokenGenerator, UserManager<UserModel> _userManager)
        {
            jwtTokenGenerator = _jwtTokenGenerator;
            userManager = _userManager;
        }


        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserQuery user)
        {
            var userModel = await userManager.FindByNameAsync(user.username);
            if (userModel is null)
                return NotFound("User not found");

            var checkPassword = await userManager.CheckPasswordAsync(userModel, user.password);
            if (!checkPassword)
                return NotFound("Bad credentials");

            var token = jwtTokenGenerator.GenerateToken(userModel.Username, DateTime.Now);
            return Ok(token);
        }
    }
}
