using System.Threading.Tasks;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Presentation.Web.Services;

namespace SatvaPartyRegister.Presentation.Web.Controllers
{
    public class ITRegisterController : Controller
    {
        private readonly ITRegisterService _itRegisterService;
        public ITRegisterController(ITRegisterService itRegisterService)
        {
            _itRegisterService = itRegisterService;
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<IActionResult> GetAll([DataSourceRequest] DataSourceRequest request)
        {
            var data = await _itRegisterService.GetAll(request);
            return Json(data.ResponseObject);
        }
    }
}