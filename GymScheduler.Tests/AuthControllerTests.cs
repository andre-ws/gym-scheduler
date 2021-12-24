using FluentAssertions;
using GymScheduler.Controllers;
using GymScheduler.Tests.Commons;
using Microsoft.Extensions.Logging;
using Moq;
using System;
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

            controller
                .Invoking(c => c.Register(new RegisterUserRequest()))
                .Should().Throw<Exception>().WithMessage("Invalid Username");
        }

        private AuthController CreateController()
        {
            using var dataContext = new GymSchedulerDbContext(ContextOptions);
            var loggerMock = new Mock<ILogger<AuthController>>();
            return new AuthController(loggerMock.Object, dataContext);
        }
    }
}
