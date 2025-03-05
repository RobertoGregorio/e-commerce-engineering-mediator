using e.commerce.egineering.infrastructure.Data.EntityConfigurations;
using e.commerce.engineering.domain.Aggregates.UserAggregates;
using e_commerce_engineering.domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data.Common;
using System.Reflection.Metadata;

namespace e.commerce.egineering.infrastructure.Data.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDbConnectionManager dbConnectionManager) : DbContext(options)
    {
        private readonly IDbConnectionManager dbConnectionManager = dbConnectionManager;

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbconnection = dbConnectionManager.GetConnection();

            optionsBuilder
                .UseMySql(connection: dbconnection,
                          serverVersion: new MySqlServerVersion(dbconnection.ServerVersion))
               // .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .LogTo(Console.WriteLine, LogLevel.Error);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserEntityTypeConfiguration().Configure(builder: modelBuilder.Entity<User>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
