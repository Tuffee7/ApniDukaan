using Microsoft.Extensions.DependencyInjection;

namespace ApniDukaan.Infrastructure
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Extension methods for registering infrastructure services in the dependency injection container.
        /// </summary>
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // TODO: Add your services to the IoC container
            // Infrastructure services often include things like database contexts/access,
            // caching, file storage services and other low level components etc.

            return services;
        }
    }
}
