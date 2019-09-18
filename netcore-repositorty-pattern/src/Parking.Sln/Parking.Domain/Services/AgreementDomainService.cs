using Parking.Domain.Interface;

namespace Parking.Domain.Services
{
    public class AgreementDomainService : IAgreementDomainService
    {
        private ParkingDataContext _context { get; set; }

        public AgreementDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(Domain.Agreement agreement)
        {
            try
            {
                _context.Agreements.Add(agreement);

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
