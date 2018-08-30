using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain
{
    public class AccountantAdvocateEntity : BaseAuditableTenantEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
