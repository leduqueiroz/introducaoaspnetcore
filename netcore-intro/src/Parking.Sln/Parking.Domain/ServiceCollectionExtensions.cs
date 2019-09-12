using Microsoft.Extensions.DependencyInjection;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ParkingDataContext, ParkingDataContext>();

            return services;
        }
    }
}