using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain.Services
{
    public class RateDomainService : IRateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public RateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(RateDto rateDto)
        {
            try
            {
                _context.Rates.Add(new Rate()
                {
                    Description = rateDto.Description,
                    DailyAmount = rateDto.DailyAmount,
                    HourAmount = rateDto.HourAmount,
                    OvernightAmount = rateDto.OvernightAmount
                });

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
