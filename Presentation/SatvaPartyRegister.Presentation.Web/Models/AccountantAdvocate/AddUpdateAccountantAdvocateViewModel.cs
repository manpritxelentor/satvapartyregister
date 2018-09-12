using System.ComponentModel;

namespace SatvaPartyRegister.Presentation.Web.Models.AccountantAdvocate
{
    public class AddUpdateAccountantAdvocateViewModel : BaseValidateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }
    }
}
