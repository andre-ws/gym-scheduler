using Microsoft.EntityFrameworkCore;

namespace GymScheduler.Tests
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
