using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class RateDomainService : IRateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public RateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Rate rate)
        {
            try
            {
                _context.Rates.Add(rate);

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
