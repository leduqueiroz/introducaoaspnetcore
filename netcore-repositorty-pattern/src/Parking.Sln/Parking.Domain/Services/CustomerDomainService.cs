using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private ParkingDataContext _context { get; set; }

        public CustomerDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);

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
