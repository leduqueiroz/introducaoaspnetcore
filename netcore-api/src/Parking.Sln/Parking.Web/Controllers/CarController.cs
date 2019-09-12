using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarAppService _carAppService { get; set; }

        public CarController(ICarAppService carAppService)
        {
            _carAppService = carAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Car car)
        {
            if (_carAppService.Create(car))
                return Ok(car);
            else
                return BadRequest();
        }
    }
}