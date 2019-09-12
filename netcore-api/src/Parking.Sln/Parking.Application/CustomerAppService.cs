using Parking.Application.Interface;
using Parking.Domain.Interface;

namespace Parking.Application
{
    public class CustomerAppService : ICustomerAppService
    {
        public ICustomerDomainService _customerDomainService { get; set; }

        public CustomerAppService(ICustomerDomainService customerDomainService)
        {
            _customerDomainService = customerDomainService;
        }

        public bool Create(Domain.Customer customer)
        {
            return _customerDomainService.Create(customer);
        }
    }
}
