using SatvaPartyRegister.Model.BaseClass;

namespace SatvaPartyRegister.Model
{
    public class FinancialYearListModel : BaseAuditableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
