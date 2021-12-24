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

        public GymSchedulerDbContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
