using Microsoft.AspNetCore.Mvc;
using Refit;
using Shared;

namespace FirstClientApi.Controllers
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
        public async Task<string> GetFromSecondApi()
        {
            var service = RestService.For<ISecondClientService>("https://localhost:7046");
            return await service.GetOtherVaslues();
        }
    }
}