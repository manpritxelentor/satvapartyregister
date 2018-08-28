using SatvaPartyRegister.Model.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Model
{
    public class FinancialYearListModel : BaseAuditableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
