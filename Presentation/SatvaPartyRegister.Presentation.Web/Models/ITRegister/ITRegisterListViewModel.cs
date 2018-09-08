using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Models.ITRegister
{
    public class ITRegisterListViewModel:BaseViewModel
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
