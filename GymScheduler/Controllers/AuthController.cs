using Microsoft.AspNetCore.Mvc;

namespace GymScheduler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly GymSchedulerDbContext dbContext;

        public AuthController(ILogger<AuthController> logger, GymSchedulerDbContext dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }

        [HttpGet(Name = "register")]
        public RegisterUserResponse Register(RegisterUserRequest request)
        {
            return null;
        }

        public class RegisterUserRequest
        {
            public string UserName { get; set; }

            public string Password { get; set; }
        }

        public class RegisterUserResponse
        {
            public int Id { get; set; }

            public string UserName { get; set; }
        }
    }
}
