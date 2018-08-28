using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public IActionResult Get()
        {
            var data = _financialYearService.GetAll().ToList();
            return Ok(data);
        }
    }
}