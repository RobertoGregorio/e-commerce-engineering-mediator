using e.commerce.egineering.infrastructure.Data.EntityConfigurations;
using e.commerce.engineering.domain.Aggregates.UserAggregates;
using e_commerce_engineering.domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.Logging;

namespace e.commerce.egineering.infrastructure.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IDbConnectionManager dbConnectionManager;

        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options) { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IDbConnectionManager dbConnectionManager) : base(options)
        {
            this.dbConnectionManager = dbConnectionManager;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                var dbconnection = dbConnectionManager.GetConnection();

                optionsBuilder
                    .UseMySql(connection: dbconnection,
                              serverVersion: new MySqlServerVersion(dbconnection.ServerVersion))
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .LogTo(Console.WriteLine, LogLevel.Error);
            }
           

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new UserEntityTypeConfiguration().Configure(builder: modelBuilder.Entity<User>());

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Remove(typeof(ForeignKeyIndexConvention));
        }

    }
}
