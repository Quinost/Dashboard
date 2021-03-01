using Dashboard.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Dashboard.Server.Controllers
{
    //TODO: Protect controller
    [Route("api/bugs")]
    [ApiController]
    public class BugsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetBugs()
        {
            //Dummy data
            var list = new List<BugModel>();

            for(int i = 0; i < 100; i++)
            {
                list.Add(new BugModel
                {
                    Id = i,
                    Message = "Error number: " + i,
                    System = "System number: " + i,
                    Date = DateTime.Now
                });
            }
            return Ok(list);
        }
    }
}
