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
        private readonly IBugService _bugService;
        private readonly IUserService _userService;

        public UsersController(IBugService bugService, IUserService userService)
        {
            _bugService = bugService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsers();
                return Ok(users.RetVal);
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser([FromBody]UserModel user)
        {
            try
            {
                var result = await _userService.UpdateUser(user);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AddUser([FromBody]UserModel user)
        {
            try
            {
                var result = await _userService.AddUser(user);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("roles")]
        public async Task<IActionResult> GetRoles()
        {
            try
            {
                var result = await _userService.GetRoles();
                if (result.Succeeded)
                    return Ok(result.RetVal);
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route("roles")]
        public async Task<IActionResult> SaveRole([FromBody]RoleModel role)
        {
            try
            {
                var result = await _userService.AddRole(role.Name);
                if (result.Succeeded)
                    return Ok();
                else
                    return BadRequest(result.ErrorToString());
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }
    }
}
