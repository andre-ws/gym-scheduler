using Microsoft.AspNetCore.Mvc;

namespace GymScheduler.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "register")]
        public void Get()
        {
        }
    }
}
