using SatvaPartyRegister.Model.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Model
{
    public class AddUpdateAccountantAdvocateModel : BaseValidateAuditableModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
    }
}
