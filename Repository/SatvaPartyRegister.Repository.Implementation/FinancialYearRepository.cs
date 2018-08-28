using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Implementation.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Repository.Implementation
{
    public class FinancialYearRepository : GenericRepository<FinancialYearEntity>
        , IFinancialYearRepository
    {
        public FinancialYearRepository(IDataContext dataContext) 
            : base(dataContext)
        {
        }
    }
}
