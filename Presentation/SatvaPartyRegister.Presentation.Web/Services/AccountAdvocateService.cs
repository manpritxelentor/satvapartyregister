using Kendo.Mvc.UI;
using SatvaPartyRegister.Presentation.Web.Helpers;
using SatvaPartyRegister.Presentation.Web.Models.AccountantAdvocate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Services
{
    public class AccountAdvocateService : BaseService
    {
        private readonly ApiClient _apiClient;

        public AccountAdvocateService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<ApiResponse<KendoResultModel<AccountantAdvocateListViewModel>>> GetAll(DataSourceRequest request)
        {
            return _apiClient.PostAsync<DataSourceRequest, KendoResultModel<AccountantAdvocateListViewModel>>("AccountantAdvocate", request);
        }
    }
}
