using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Services.Interfaces;
using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Dashboard.Server.Controllers
{
    [Route("api/bugs")]
    [ApiController]
    [Authorize]
    public class BugsController : ControllerBase
    {
        private readonly IBugService _bugService;

        public BugsController(IBugService bugService)
        {
            _bugService = bugService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBugs([FromQuery] int startIndex, [FromQuery] int count)
        {
            try
            {
                var bugs = await _bugService.GetBugs(startIndex, count);
                if (bugs.Succeeded)
                    return Ok(bugs.RetVal);
                else
                    return NotFound(bugs.ErrorToString());
            }
            catch(Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API" );
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<IActionResult> SaveBug([FromBody]BugModel bug)
        {
            try
            {
                await _bugService.SaveBug(bug.Message, bug.System, bug.Date);
                return Ok();
            }
            catch (Exception ex)
            {
                await _bugService.SaveBug(ex.Message, "CORE API");
                return StatusCode(500);
            }
        }
    }
}
