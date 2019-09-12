using Parking.Application.Interface;
using Parking.Domain.Interface;

namespace Parking.Application
{
    public class AssociateAppService : IAssociateAppService
    {
        public IAssociateDomainService _associateDomainService { get; set; }

        public AssociateAppService(IAssociateDomainService associateDomainService)
        {
            _associateDomainService = associateDomainService;
        }

        public bool Create(Domain.Associate associate)
        {
            return _associateDomainService.Create(associate);
        }
    }
}
