using System.Threading.Tasks;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult List()
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