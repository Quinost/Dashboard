using Dashboard.Server.Context.Entity;
using Dashboard.Server.Services;
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
        private readonly BugService bugService;

        public BugsController(BugService _bugService)
        {
            bugService = _bugService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBugs([FromQuery] int startIndex, [FromQuery] int count)
        {
            try
            {
                var bugs = await bugService.GetBugs(startIndex, count);
                return Ok(bugs);
            }
            catch(Exception ex)
            {
                await bugService.SaveBug(new BugEntity { Message = ex.Message, System = "CORE API" });
                return StatusCode(500);
            }
        }
    }
}
