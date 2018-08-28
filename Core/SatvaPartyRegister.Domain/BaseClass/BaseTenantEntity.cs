using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain.BaseClass
{
    public abstract class BaseTenantEntity : BaseEntity
    {
        public string TenantId { get; set; }
    }
}
