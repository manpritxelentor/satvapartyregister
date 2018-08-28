using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Presentation.Web.Models.FinancialYear;
using SatvaPartyRegister.Presentation.Web.Services;

namespace SatvaPartyRegister.Presentation.Web.Controllers
{
    public class FinancialYearController : Controller
    {
        private readonly FinancialYearService _financialYearService;
        public FinancialYearController(FinancialYearService financialYearService)
        {
            _financialYearService = financialYearService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetFinancialYear([DataSourceRequest] DataSourceRequest request)
        {
            var data = await _financialYearService.GetAll(request);
            return Json(data.ResponseObject);
        }
    }
}