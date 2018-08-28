using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain.BaseClass
{
    public abstract class BaseAuditableTenantEntity : BaseAuditableEntity
    {
        public string TenantId { get; set; }
    }
}
