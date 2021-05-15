using Dashboard.Server.Services.Helpers;
using Dashboard.Server.Services.Identity;
using Dashboard.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers
{
    [Route("api/configuration")]
    [ApiController]
    [Authorize]
    public class ConfigurationController : ControllerBase
    {
        private readonly WatcherHelper _helper;
        private readonly JwtConfig _config;

        public ConfigurationController(WatcherHelper helper, JwtConfig config)
        {
            _helper = helper;
            _config = config;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                ConfigurationModel retVal = new ConfigurationModel();
                retVal.WatcherWorkerDelayTime = _helper.OnDelay(null);
                retVal.TokenExpirationTime = _config.AccessTokenExpiration;
                return Ok(retVal);
            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Change([FromBody] ConfigurationModel model)
        {
            _helper.OnDelay(model.WatcherWorkerDelayTime);

            return Ok();
        }
    }
}
