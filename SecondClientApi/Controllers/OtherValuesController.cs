using Microsoft.AspNetCore.Mvc;

namespace SecondClientApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OtherValuesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<OtherValuesController> _logger;

        public OtherValuesController(ILogger<OtherValuesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return Summaries[Random.Shared.Next(Summaries.Length)];
        }
    }
}