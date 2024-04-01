using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AstroPizza.Application
{
    public static class AddApplicationServices
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));            

            return services;
        }
    }
}
