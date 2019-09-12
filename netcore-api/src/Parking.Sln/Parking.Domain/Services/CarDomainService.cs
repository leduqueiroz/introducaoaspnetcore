using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class CarDomainService : ICarDomainService
    {
        private ParkingDataContext _context { get; set; }

        public CarDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Car car)
        {
            try
            {
                _context.Cars.Add(car);

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
