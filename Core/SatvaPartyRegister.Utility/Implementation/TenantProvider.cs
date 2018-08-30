using Microsoft.AspNetCore.Http;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Utility.Implementation
{
    public class TenantProvider : ITenantProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public TenantProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string TenantId
        {
            get
            {
                // TODO: Get from Header
                return "6EC85B58-A183-4580-ABD1-0B36BF7696F3";
            }
        }
    }
}
