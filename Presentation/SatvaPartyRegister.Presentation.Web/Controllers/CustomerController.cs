using System.Threading.Tasks;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Presentation.Web.Services;

namespace SatvaPartyRegister.Presentation.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult List()
        {
            return View();
        }

        public async Task<IActionResult> GetAll([DataSourceRequest] DataSourceRequest request)
        {
            var data = await _customerService.GetAll(request);
            return Json(data.ResponseObject);
        }
    }
}