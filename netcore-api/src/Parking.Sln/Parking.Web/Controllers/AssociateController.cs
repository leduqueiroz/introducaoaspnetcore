using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateController : ControllerBase
    {
        public IAssociateAppService _associateAppService { get; set; }

        public AssociateController(IAssociateAppService associateAppService)
        {
            _associateAppService = associateAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Associate associate)
        {
            if (_associateAppService.Create(associate))
                return Ok(associate);
            else
                return BadRequest();
        }
    }
}