using SatvaPartyRegister.Domain.BaseClass;

namespace SatvaPartyRegister.Domain
{
    public class ITRegisterEntity:BaseAuditableTenantEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int FinYearId { get; set; }
        public int ITReturnStatusId { get; set; }
        public int? ITReturnStatusBy { get; set; }
        public int AuditStatusId { get; set; }
        public int? AuditStatusBy { get; set; }
    }
}
