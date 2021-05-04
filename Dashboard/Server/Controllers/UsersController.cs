using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Controllers
{
    [Route("api/users")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IBugService bugService;
        private readonly IUserService userService;

        public UsersController(IBugService _bugService, IUserService _userService)
        {
            bugService = _bugService;
            userService = _userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await userService.GetUsers();
                return Ok(users.RetVal);
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody]UserModel user)
        {
            try
            {
                var result = await userService.UpdateUser(user);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AddUser([FromBody]UserModel user)
        {
            try
            {
                var result = await userService.AddUser(user);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("roles")]
        public async Task<IActionResult> GetRoles()
        {
            try
            {
                var result = await userService.GetRoles();
                if (result.Succeeded)
                    return Ok(result.RetVal);
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }
    }
}
