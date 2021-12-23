using Microsoft.EntityFrameworkCore;

namespace GymScheduler.Tests.Commons
{
    public class GymSchedulerContextBaseTest
    {
        protected DbContextOptions<GymSchedulerDbContext> ContextOptions { get; }

        public GymSchedulerContextBaseTest(DbContextOptions<GymSchedulerDbContext> contextOptions)
        {
            ContextOptions = contextOptions;

            Seed();
        }

        private void Seed()
        {
            // do seeding stuffs
        }
    }
}
