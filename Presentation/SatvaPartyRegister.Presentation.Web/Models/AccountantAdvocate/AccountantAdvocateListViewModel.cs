using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Models.AccountantAdvocate
{
    public class AccountantAdvocateListViewModel : BaseValidateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
