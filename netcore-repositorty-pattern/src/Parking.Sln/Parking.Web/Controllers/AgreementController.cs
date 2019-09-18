using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgreementController : ControllerBase
    {
        private IAgreementAppService _agremmentAppService { get; set; }

        public AgreementController(IAgreementAppService agremmentAppService)
        {
            _agremmentAppService = agremmentAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Agreement agremment)
        {
            if (_agremmentAppService.Create(agremment))
                return Ok(agremment);
            else
                return BadRequest();
        }
    }
}