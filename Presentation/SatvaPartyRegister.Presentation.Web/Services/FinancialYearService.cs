using Kendo.Mvc.UI;
using SatvaPartyRegister.Presentation.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Services
{
    public class FinancialYearService
    {
        private readonly ApiClient _apiClient;

        public FinancialYearService(ApiClient apiClient)
        {
            _apiClient = apiClient;
        }
        public Task<ApiResponse<Rootobject>> GetAll(DataSourceRequest request)
        {
            return _apiClient.PostAsync<DataSourceRequest, Rootobject>("FinancialYear", request);
        }
    }
}
