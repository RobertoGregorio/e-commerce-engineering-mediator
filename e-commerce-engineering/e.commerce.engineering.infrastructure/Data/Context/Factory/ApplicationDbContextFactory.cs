using e.commerce.engineering.domain.Aggregates.UserAggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace e.commerce.egineering.infrastructure.Data.Context.Factory;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        try
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile(Directory.GetCurrentDirectory() + "\\Data\\Context\\Factory\\ApplicationDbContextFactorySettings.json")
            .AddUserSecrets<ApplicationDbContextFactory>()
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Database connectionstring: " + connectionString);

            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
        catch(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ex.Message);
            return null;
        }
    }
}
