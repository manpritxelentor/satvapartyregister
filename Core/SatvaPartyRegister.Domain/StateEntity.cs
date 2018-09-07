using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain
{
    public class StateEntity:BaseAuditableTenantEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int CountryId { get; set; }
        public string StateName { get; set; }
        public string ShortCode { get; set; }
        public string StateCode { get; set; }
        public virtual CountryEntity Country { get; set; }

    }
}
