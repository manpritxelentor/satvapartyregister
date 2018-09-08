using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Service.Contract;

namespace SatvaPartyRegister.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ITRegisterController : BaseController
    {
        private readonly IITRegisterService _itRegisterService;

        public ITRegisterController(IITRegisterService itRegisterService)
        {
            _itRegisterService = itRegisterService;
        }

        [HttpPost]
        public IActionResult Get(DataSourceRequest request)
        {
            var data = _itRegisterService.GetAll()
                .ToDataSourceResult(request);
            return Ok(data);
        }
    }
}