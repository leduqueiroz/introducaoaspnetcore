using Parking.Application.Interface;
using Parking.Domain.Interface;

namespace Parking.Application
{
    public class CarAppService : ICarAppService
    {
        public ICarDomainService _carDomainService { get; set; }

        public CarAppService(ICarDomainService carDomainService)
        {
            _carDomainService = carDomainService;
        }

        public bool Create(Domain.Car car)
        {
            return _carDomainService.Create(car);
        }
    }
}
