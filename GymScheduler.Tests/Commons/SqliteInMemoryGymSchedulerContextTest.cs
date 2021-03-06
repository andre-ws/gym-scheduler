using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Data.Common;

namespace GymScheduler.Tests.Commons
{
    public class SqliteInMemoryGymSchedulerContextTest : GymSchedulerContextBaseTest, IDisposable
    {
        private readonly DbConnection connection;

        public SqliteInMemoryGymSchedulerContextTest()
            : base(
                new DbContextOptionsBuilder<GymSchedulerDbContext>()
                    .UseSqlite(CreateInMemoryDatabase())
                    .Options)
        {
            connection = RelationalOptionsExtension.Extract(ContextOptions).Connection;
        }

        public void Dispose() => connection.Dispose();

        private static DbConnection CreateInMemoryDatabase()
        {
            return new SqliteConnection("Filename=:memory:");
        }
    }
}
