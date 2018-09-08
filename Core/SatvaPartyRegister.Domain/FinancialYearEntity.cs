using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain
{
    public class FinancialYearEntity : BaseAuditableTenantEntity
    {
        public FinancialYearEntity()
        {
            ITRegisters = new List<ITRegisterEntity>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ITRegisterEntity> ITRegisters { get; set; }

    }
}
