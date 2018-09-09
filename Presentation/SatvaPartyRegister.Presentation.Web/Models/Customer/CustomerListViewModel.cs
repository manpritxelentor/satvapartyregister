using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Models.Customer
{
    public class CustomerListViewModel:BaseViewModel
    {
        public int Id { get; set; }
        public int CustomerTypeId { get; set; }

        [DisplayName("Customer Type")]
        public string CustomerType { get; set; }
        public int ReturnIntervalId { get; set; }

        [DisplayName("Customer Name")]
        public string PrimaryContactName { get; set; }

        [DisplayName("Firm Name")]
        public string FirmName { get; set; }

        [DisplayName("Reff Name")]
        public string ReffName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }
        public string EmailAddress { get; set; }
        public string AdharNumber { get; set; }
        public string PanNumber { get; set; }
        public string ITFileNumber { get; set; }
        public string ITUserId { get; set; }
        public string ITPassword { get; set; }
        public string GSTNumber { get; set; }
        public string GSTFileNumber { get; set; }
        public string GSTUserId { get; set; }
        public string GSTPassword { get; set; }
        public string EwayBillId { get; set; }
        public string EwayPassword { get; set; }
        public string VATId { get; set; }
        public string VATPassword { get; set; }
        public int? AccountantId { get; set; }

        [DisplayName("Accountant")]
        public string AccountantName { get; set; }
        public int? AdvocateId { get; set; }

        [DisplayName("Advocate")]
        public string AdvocateName { get; set; }
    }
}
