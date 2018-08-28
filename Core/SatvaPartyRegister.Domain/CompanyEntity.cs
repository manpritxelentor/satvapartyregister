using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain
{
    public class CompanyEntity : BaseAuditableEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}
