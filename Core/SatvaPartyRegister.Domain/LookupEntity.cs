using SatvaPartyRegister.Domain.BaseClass;
using System.Collections.Generic;

namespace SatvaPartyRegister.Domain
{
    public class LookupEntity:BaseAuditableTenantEntity
    {
        public LookupEntity()
        {
            Customers = new List<CustomerEntity>();
            Customers1 = new List<CustomerEntity>();
            ITRegisters = new List<ITRegisterEntity>();
            ITRegisters1 = new List<ITRegisterEntity>();
        }
        public int Id { get; set; }
        public string LookupGroup { get; set; }
        public string LookupName { get; set; }
        public string LookupCode { get; set; }
        public string LookupValue { get; set; }
        public virtual ICollection<CustomerEntity> Customers { get; set; }
        public virtual ICollection<CustomerEntity> Customers1  { get; set; }
        public virtual ICollection<ITRegisterEntity> ITRegisters { get; set; }
        public virtual ICollection<ITRegisterEntity> ITRegisters1 { get; set; }
    }
}
