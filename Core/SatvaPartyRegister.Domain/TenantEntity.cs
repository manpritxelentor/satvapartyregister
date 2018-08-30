using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain
{
    public class TenantEntity : BaseAuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
