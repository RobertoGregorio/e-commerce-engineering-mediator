using e.commerce.egineering.infrastructure.Data;
using e.commerce.egineering.infrastructure.Data.Context;
using e.commerce.engineering.domain.Repositorys;
using e_commerce_engineering.domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace e.commerce.engineering.crosscutting
{
    public static class DependenciesContainer
    {
        public static void RegisterDependencies(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IDbConnectionManager, DbConnectionManager>();
            serviceCollection.AddDbContext<ApplicationDbContext>();

            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

        }
    }
}
