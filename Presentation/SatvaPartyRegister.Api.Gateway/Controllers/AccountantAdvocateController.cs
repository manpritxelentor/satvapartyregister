using System.Threading.Tasks;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using SatvaPartyRegister.Api.Gateway.Helpers;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Service.Contract;

namespace SatvaPartyRegister.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountantAdvocateController : BaseController
    {
        private readonly IAccountantAdvocateService _accountantAdvocateService;
        private readonly IdentityHelper _identityHelper;

        public AccountantAdvocateController(IAccountantAdvocateService accountantAdvocateService
            , IdentityHelper identityHelper)
        {
            _accountantAdvocateService = accountantAdvocateService;
            _identityHelper = identityHelper;
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get(DataSourceRequest request)
        {
            var data = await _accountantAdvocateService.GetAll()
                    .ToDataSourceResultAsync(request);
            return Ok(data);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post(AddUpdateAccountantAdvocateModel addUpdateAccountantAdvocateModel)
        {
            var data = await _accountantAdvocateService.InsertAsync(_identityHelper.UserId, addUpdateAccountantAdvocateModel);
            return Ok(data);
        }

        [HttpPost("Put/{id}")]
        public async Task<IActionResult> Put(int id, AddUpdateAccountantAdvocateModel addUpdateAccountantAdvocateModel)
        {
            var data = await _accountantAdvocateService.UpdateAsync(id, _identityHelper.UserId, addUpdateAccountantAdvocateModel);
            return Ok(data);
        }

        [HttpPost("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _accountantAdvocateService.DeleteAsync(id, _identityHelper.UserId);
            return Ok(data);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _accountantAdvocateService.GetByIdAsync(id);
            return Ok(data);
        }
    }
}