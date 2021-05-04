using Dashboard.Infrastructure.Entity;
using Dashboard.Server.Services.Interfaces;
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
        private readonly IBugService bugService;

        public BugsController(IBugService _bugService)
        {
            bugService = _bugService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBugs([FromQuery] int startIndex, [FromQuery] int count)
        {
            try
            {
                var bugs = await bugService.GetBugs(startIndex, count);
                if (bugs.Succeeded)
                    return Ok(bugs.RetVal);
                else
                    return NotFound(bugs.ErrorToString());
            }
            catch(Exception ex)
            {
                await bugService.SaveBug(ex.Message, "CORE API" );
                return StatusCode(500);
            }
        }
    }
}
