using Parking.Dto;

namespace Parking.Domain.Interface
{
    public interface IRateDomainService
    {
        bool Create(RateDto rateDto);
    }
}
