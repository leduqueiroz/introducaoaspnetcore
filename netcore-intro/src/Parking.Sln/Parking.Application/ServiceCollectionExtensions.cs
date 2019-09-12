using Microsoft.Extensions.DependencyInjection;
using Parking.Application.Interface;

namespace Parking.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddTransient<IParkingAppService, ParkingAppService>();

            return services;
        }
    }
}
