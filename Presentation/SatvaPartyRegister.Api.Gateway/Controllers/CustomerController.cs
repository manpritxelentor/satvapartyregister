using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Service.Contract;

namespace SatvaPartyRegister.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public IActionResult Get(DataSourceRequest request)
        {
            var data = _customerService.GetAll()
                .ToDataSourceResult(request);
            return Ok(data);
        }
    }
}