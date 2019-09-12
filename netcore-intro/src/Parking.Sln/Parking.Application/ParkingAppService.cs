using Parking.Application.Interface;

namespace Parking.Application
{
    public class ParkingAppService : IParkingAppService
    {
        public ParkingAppService()
        {
        }

        public bool Create(Domain.Parking parking)
        {
            return true;
        }
    }
}
