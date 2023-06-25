using Microsoft.AspNetCore.Mvc;

namespace AWS.CloudWatch.Serilog.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
            => _logger = logger;

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogDebug("Debug Log");
            _logger.LogInformation("Information Log");
            _logger.LogError("Error Log");
            return Ok();
        }
    }
}
