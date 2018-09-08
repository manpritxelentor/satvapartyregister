using SatvaPartyRegister.Model.BaseClass;

namespace SatvaPartyRegister.Model
{
    public class ITRegisterListModel : BaseAuditableModel
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
