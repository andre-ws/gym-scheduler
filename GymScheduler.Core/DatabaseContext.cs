using GymScheduler.Model;
using Microsoft.EntityFrameworkCore;

namespace GymScheduler.Core
{
    public class GymSchedulerContext : DbContext
    {
        public GymSchedulerContext(DbContextOptions<GymSchedulerContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<MatRoom> MatRooms { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>().ToTable("Class");
            modelBuilder.Entity<ClassType>().ToTable("ClassType");
            modelBuilder.Entity<MatRoom>().ToTable("MatRoom");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
