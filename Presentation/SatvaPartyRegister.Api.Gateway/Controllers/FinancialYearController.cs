using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Service.Contract;

namespace SatvaPartyRegister.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialYearController : ControllerBase
    {
        private readonly IFinancialYearService _financialYearService;

        public FinancialYearController(IFinancialYearService financialYearService)
        {
            _financialYearService = financialYearService;
        }

        [HttpPost]
        public IActionResult Get(DataSourceRequest request)
        {
            var data = _financialYearService.GetAll()
                .ToDataSourceResult(request);
            return Ok(data);
        }
    }
}