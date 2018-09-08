using Kendo.Mvc.UI;
using SatvaPartyRegister.Presentation.Web.Helpers;
using SatvaPartyRegister.Presentation.Web.Models.Customer;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Services
{
    public class CustomerService:BaseService
    {
        private readonly ApiClient _apiClient;

        public CustomerService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<ApiResponse<KendoResultModel<CustomerListViewModel>>> GetAll(DataSourceRequest request)
        {
            return _apiClient.PostAsync<DataSourceRequest, KendoResultModel<CustomerListViewModel>>("Customer", request);
        }
    }
}
