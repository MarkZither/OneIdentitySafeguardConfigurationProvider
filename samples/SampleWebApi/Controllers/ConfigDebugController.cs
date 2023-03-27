using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleWebApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ConfigDebugController : ControllerBase {
        
        private readonly ILogger<ConfigDebugController> _logger;
        private readonly IConfigurationRoot _config;

        public ConfigDebugController(ILogger<ConfigDebugController> logger, IConfiguration config) {
            _logger = logger;
            _config = (IConfigurationRoot)config;
        }

        [HttpGet(Name = "GetConfigDebugView")]
        public IActionResult Get() {
            return Ok((_config as IConfigurationRoot).GetDebugView());
        }
    }
}