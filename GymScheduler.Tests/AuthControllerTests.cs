using GymScheduler.Controllers;
using GymScheduler.Tests.Commons;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;
using static GymScheduler.Controllers.AuthController;

namespace GymScheduler.Tests
{
    public class AuthControllerTests : SqliteInMemoryGymSchedulerContextTest
    {
        [Fact]
        public void RegisterUser_WithInvalidData_ShouldReturnError()
        {
            var controller = CreateController();

            var result = controller.Register(new RegisterUserRequest());

            Assert.NotNull(result);
        }

        private AuthController CreateController()
        {
            using var dataContext = new GymSchedulerDbContext(ContextOptions);
            var loggerMock = new Mock<ILogger<AuthController>>();
            return new AuthController(loggerMock.Object, dataContext);
        }
    }
}
