using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;

namespace Parking.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public ICustomerAppService _customerAppService { get; set; }

        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        [HttpPost]
        public IActionResult Create([FromBody]Domain.Customer customer)
        {
            if (_customerAppService.Create(customer))
                return Ok(customer);
            else
                return BadRequest();
        }
    }
}