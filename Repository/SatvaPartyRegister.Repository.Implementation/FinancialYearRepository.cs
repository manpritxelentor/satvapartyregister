﻿using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Implementation.BaseClass;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Repository.Implementation
{
    public class FinancialYearRepository : GenericRepository<FinancialYearEntity>
        , IFinancialYearRepository
    {
        public FinancialYearRepository(IDataContext dataContext
            , ITenantProvider tenantProvider)
            : base(dataContext, tenantProvider)
        {
        }
    }
}
