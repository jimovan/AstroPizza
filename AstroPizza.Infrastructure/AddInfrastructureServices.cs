using AstroPizza.Application.Common.Interfaces;
using AstroPizza.Application.Toppings;
using AstroPizza.Infrastructure.Data;
using AstroPizza.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AstroPizza.Infrastructure
{
    public static partial class AddInfrastructureServices
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AstroPizzaDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("AstroPizza"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IToppingRepository, ToppingRepository>();

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public class AstroPizzaDbContextFactory : IDesignTimeDbContextFactory<AstroPizzaDbContext>
        {
            public AstroPizzaDbContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("AstroPizza");

                var builder = new DbContextOptionsBuilder<AstroPizzaDbContext>();
                builder.UseSqlServer(connectionString);

                return new AstroPizzaDbContext(builder.Options);
            }
        }
    }
}
