using SatvaPartyRegister.Domain.BaseClass;

namespace SatvaPartyRegister.Domain
{
    public class CountryEntity:BaseAuditableTenantEntity
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
    }
}
