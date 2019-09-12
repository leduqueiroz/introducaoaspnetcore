using Parking.Application.Interface;
using Parking.Domain.Interface;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        private IParkingDomainService _parkingDomainService { get; set; }

        public ParkingAppService(IParkingDomainService parkingDomainService)
        {
            _parkingDomainService = parkingDomainService;
        }

        public bool Create(Domain.Parking parking)
        {
            return _parkingDomainService.Create(parking);
        }
    }
}
