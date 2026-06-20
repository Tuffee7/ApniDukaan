using ApniDukaan.Core.ServiceContracts;
using ApniDukaan.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApniDukaan.Core
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension methods for registering infrastructure services in the dependency injection container.
        /// </summary>
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            // TODO: Add your services to the IoC container
            // Infrastructure services often include things like database contexts/access,
            // caching, file storage services and other low level components etc.

            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
