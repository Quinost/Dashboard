using AutoMapper;
using Dashboard.Functions.Functions.Bugs.Queries.GetBugsList;
using Dashboard.Functions.Notifications.SendBug;
using Dashboard.Shared;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers;
[Route("api/bugs")]
[ApiController]
[Authorize]
public class BugsController : ControllerBase
{
    private readonly IMediator mediator;
    private readonly IMapper mapper;

    public BugsController(IMediator mediator, IMapper mapper)
    {
        this.mediator = mediator;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetBugs([FromQuery] int startIndex, [FromQuery] int count)
    {
        try
        {
            Thread.Sleep(4000);
            var bugs = await mediator.Send(new GetBugsListQuery(startIndex, count));
            return Ok(mapper.Map<BugsWithCountModel>(bugs));
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpPut]
    public async Task<IActionResult> SaveBug([FromBody]BugModel bug)
    {
        try
        {
            await mediator.Publish(new SendBugEvent(bug.Message, bug.System));
            return Ok();
        }
        catch (Exception ex)
        {
            await mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }
}
