using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
        public IRateAppService _rateAppService { get; set; }

        public RateController(IRateAppService rateAppService)
        {
            _rateAppService = rateAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Rate rate)
        {
            if (_rateAppService.Create(rate))
                return Ok(rate);
            else
                return BadRequest();
        }
    }
}