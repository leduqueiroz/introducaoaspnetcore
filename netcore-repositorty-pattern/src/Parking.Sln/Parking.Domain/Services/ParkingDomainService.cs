using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }

        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Parking parking)
        {
            try
            {
                _context.Parking.Add(parking);

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
