using Dashboard.Server.Authentication.JWT;
using Dashboard.Server.Services.Helpers;
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
        private readonly WatcherHelper helper;
        private readonly JwtConfig config;

        public ConfigurationController(WatcherHelper _helper, JwtConfig _config)
        {
            helper = _helper;
            config = _config;
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
            catch
            {
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
}
