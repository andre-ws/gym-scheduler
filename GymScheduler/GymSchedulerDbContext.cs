using GymScheduler.Model;
using Microsoft.EntityFrameworkCore;

namespace GymScheduler
{
    public class GymSchedulerDbContext : DbContext
    {
        public string DbPath { get; }

        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<MatRoom> MatRooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

        public GymSchedulerDbContext()
        {
            // TODO: Move configuration to user secrets file
            // https://docs.microsoft.com/en-us/ef/core/miscellaneous/connection-strings
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "gym-scheduler.sqlite");

            Database.EnsureCreated();
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
