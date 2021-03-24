using Dashboard.Server.Services.Helpers;
using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers
{
    //TODO: Protect controller
    [Route("api/configuration")]
    [ApiController]
    [Authorize]
    public class ConfigurationController : ControllerBase
    {
        private WatcherHelper helper;

        public ConfigurationController(WatcherHelper _helper)
        {
            helper = _helper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ConfigurationModel retVal = new ConfigurationModel();
            retVal.WatcherWorkerDelayTime = helper.OnDelay(null);
            return Ok(retVal);
        }

        [HttpPost]
        public IActionResult Change([FromBody] ConfigurationModel model)
        {
            helper.OnDelay(model.WatcherWorkerDelayTime);

            return Ok();
        }
    }
}
