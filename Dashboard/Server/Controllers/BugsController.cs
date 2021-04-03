using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dashboard.Server.Controllers
{
    //TODO: Protect controller
    [Route("api/bugs")]
    [ApiController]
    [Authorize]
    public class BugsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBugs([FromQuery] int startIndex, [FromQuery] int count)
        {
            //Dummy data
            var list = new List<BugModel>();

            for(int i = 0; i < 500; i++)
            {
                list.Add(new BugModel
                {
                    Id = i,
                    Message = "Error number: " + i,
                    System = "System number: " + i,
                    Date = DateTime.Now
                });
            }
            list = list.OrderBy(x => x.Id).Skip(startIndex).Take(count).ToList();

            return Ok(list);
        }
    }
}
