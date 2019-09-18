using Parking.Application.Interface;
using Parking.Domain.Interface;

namespace Parking.Application
{
    public class AgreementAppService : IAgreementAppService
    {
        public IAgreementDomainService _agreementDomainService { get; set; }

        public AgreementAppService(IAgreementDomainService agreementDomainService)
        {
            _agreementDomainService = agreementDomainService;
        }

        public bool Create(Domain.Agreement agreement)
        {
            return _agreementDomainService.Create(agreement);
        }
    }
}
