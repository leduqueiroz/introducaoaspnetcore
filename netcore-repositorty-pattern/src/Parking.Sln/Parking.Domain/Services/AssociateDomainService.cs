using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class AssociateDomainService : IAssociateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public AssociateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Associate associate)
        {
            try
            {
                _context.Associates.Add(associate);

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
