using e_commerce_engineering.domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data.Common;

namespace e_commerce_egineering.infrastructure.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IDbConnectionManager dbConnectionManager;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDbConnectionManager dbConnectionManager) : base(options)
        {
            this.dbConnectionManager = dbConnectionManager;
        }

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
            base.OnModelCreating(modelBuilder);
        }
    }
}
