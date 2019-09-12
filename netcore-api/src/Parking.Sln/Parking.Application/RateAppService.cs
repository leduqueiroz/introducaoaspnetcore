using Parking.Application.Interface;
using Parking.Domain.Interface;
using System.Collections.Generic;

namespace Parking.Application
{
    public class RateAppService : IRateAppService
    {
        public IRateDomainService _rateDomainService { get; set; }

        public RateAppService(IRateDomainService rateDomainService)
        {
            _rateDomainService = rateDomainService;
        }

        public bool Create(Domain.Rate rate)
        {
            return _rateDomainService.Create(rate);
        }
    }
}
