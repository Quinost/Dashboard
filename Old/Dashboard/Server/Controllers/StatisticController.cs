using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Server.Controllers;
[Route("api/statistic")]
[ApiController]
[Authorize]
public class StatisticController : ControllerBase
{
    //TODO: Add endpoints
}
