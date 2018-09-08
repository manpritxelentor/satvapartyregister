using Kendo.Mvc.UI;
using SatvaPartyRegister.Presentation.Web.Helpers;
using SatvaPartyRegister.Presentation.Web.Models.ITRegister;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Services
{
    public class ITRegisterService:BaseService
    {
        private readonly ApiClient _apiClient;

        public ITRegisterService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<ApiResponse<KendoResultModel<ITRegisterListViewModel>>> GetAll(DataSourceRequest request)
        {
            return _apiClient.PostAsync<DataSourceRequest, KendoResultModel<ITRegisterListViewModel>>("ITRegister", request);
        }
    }
}
