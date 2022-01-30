using Dashboard.Functions.Notifications.SendBug;
using Dashboard.Infrastructure.Helpers;
using Dashboard.Server.Services.Identity;
using Dashboard.Shared;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers;

[Route("api/configuration")]
[ApiController]
[Authorize]
public class ConfigurationController : ControllerBase
{
    private readonly WatcherHelper helper;
    private readonly JwtConfig config;
    private readonly IMediator mediator;

    public ConfigurationController(WatcherHelper helper, JwtConfig config, IMediator mediator)
    {
        this.helper = helper;
        this.config = config;
        this.mediator = mediator;
    }

    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            ConfigurationModel retVal = new ConfigurationModel();
            retVal.WatcherWorkerDelayTime = helper.OnDelay(null);
            retVal.TokenExpirationTime = config.AccessTokenExpiration;
            return Ok(retVal);
        }
        catch (Exception ex)
        {
            mediator.Publish(new SendBugEvent(ex.Message, "CORE"));
            return StatusCode(500);
        }
    }

    [HttpPost]
    public IActionResult Change([FromBody] ConfigurationModel model)
    {
        helper.OnDelay(model.WatcherWorkerDelayTime);

        return Ok();
    }
}
