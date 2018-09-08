using SatvaPartyRegister.Domain.BaseClass;
using System.Collections.Generic;

namespace SatvaPartyRegister.Domain
{
    public class AccountantAdvocateEntity : BaseAuditableTenantEntity
    {
        public AccountantAdvocateEntity()
        {
            this.Customers = new List<CustomerEntity>();
            this.Customers1 = new List<CustomerEntity>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public virtual ICollection<CustomerEntity> Customers { get; set; }
        public virtual ICollection<CustomerEntity> Customers1 { get; set; }
    }
}
