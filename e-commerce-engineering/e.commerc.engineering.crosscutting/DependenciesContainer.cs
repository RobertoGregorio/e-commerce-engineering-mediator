using e_commerce_egineering.infrastructure.Data;
using e_commerce_egineering.infrastructure.Data.Context;
using Microsoft.Extensions.DependencyInjection;

namespace e.commerc.engineering.crosscutting
{
    public static class DependenciesContainer
    {
        public static void RegisterDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<DbConnectionManager>();
            serviceCollection.AddDbContext<ApplicationDbContext>();
        }
    }
}
