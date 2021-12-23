using GymScheduler.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GymScheduler.Tests
{
    public class HomeControllerTests : SqliteInMemoryGymSchedulerContextTest
    {
        [Fact]
        public void X()
        {
            using var dataContext = new GymSchedulerDbContext(ContextOptions);
            dataContext.SaveChanges();
        }
    }
}
