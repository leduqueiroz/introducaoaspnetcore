using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        public IParkingAppService _parkingAppService { get; set; }

        public ParkingController(IParkingAppService parkingAppService)
        {
            _parkingAppService = parkingAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Parking parking)
        {
            if (_parkingAppService.Create(parking))
                return Ok(parking);
            else
                return BadRequest();
        }
    }
}