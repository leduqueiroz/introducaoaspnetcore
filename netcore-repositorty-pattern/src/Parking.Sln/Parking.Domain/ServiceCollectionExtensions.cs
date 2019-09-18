using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Interface;
using Parking.Domain.Services;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainDependency(this IServiceCollection services)
        {
            services.AddScoped<ParkingDataContext, ParkingDataContext>();

            services.AddTransient<IAgreementDomainService, AgreementDomainService>();
            services.AddTransient<IParkingDomainService, ParkingDomainService>();
            services.AddTransient<IAssociateDomainService, AssociateDomainService>();
            services.AddTransient<ICarDomainService, CarDomainService>();
            services.AddTransient<ICustomerDomainService, CustomerDomainService>();
            services.AddTransient<IRateDomainService, RateDomainService>();

            return services;
        }
    }
}
