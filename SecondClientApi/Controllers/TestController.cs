using Microsoft.AspNetCore.Mvc;
using Refit;
using Shared;

namespace SecondClientApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<string>> GetFromFirstApi()
        {
            var service = RestService.For<IFirstClientService>("https://localhost:7275");
            return await service.GetValues();
        }
    }
}