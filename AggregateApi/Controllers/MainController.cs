using Microsoft.AspNetCore.Mvc;

namespace AggregateApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<MainController> _logger;

        public MainController(ILogger<MainController> logger)
        {
            _logger = logger;
        }

        [HttpGet("First")]
        public IEnumerable<string> GetFirst()
        {
            return Summaries.ToList();
        }
        
        [HttpGet("Second")]
        public string GetSecond()
        {
            return Summaries[Random.Shared.Next(Summaries.Length)];
        }
    }
}