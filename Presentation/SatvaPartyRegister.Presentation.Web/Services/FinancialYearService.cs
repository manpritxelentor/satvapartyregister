using Kendo.Mvc.UI;
using SatvaPartyRegister.Presentation.Web.Helpers;
using SatvaPartyRegister.Presentation.Web.Models.FinancialYear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Services
{
    public class FinancialYearService : BaseService
    {
        private readonly ApiClient _apiClient;

        public FinancialYearService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<ApiResponse<KendoResultModel<FinancialYearListModel>>> GetAll(DataSourceRequest request)
        {
            return _apiClient.PostAsync<DataSourceRequest, KendoResultModel<FinancialYearListModel>>("FinancialYear", request);
        }
    }
}
