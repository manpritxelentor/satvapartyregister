﻿using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;

namespace SatvaPartyRegister.Domain
{
    public class CustomerEntity:BaseAuditableTenantEntity
    {
        public CustomerEntity()
        {
            ITRegisters = new List<ITRegisterEntity>();
        }
        public int Id { get; set; }
        public int CustomerTypeId { get; set; }
        public int ReturnIntervalId { get; set; }
        public string PrimaryContactName { get; set; }
        public string FirmName { get; set; }
        public string ReffName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public DateTime? DateOfBirth { get; set; }
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
        public int? AdvocateId { get; set; }
        public virtual AccountantAdvocateEntity Accountant { get; set; }
        public virtual AccountantAdvocateEntity Advocate { get; set; }
        public virtual CountryEntity Country { get; set; }
        public virtual LookupEntity CustomerType { get; set; }
        public virtual LookupEntity ReturnInterval { get; set; }
        public virtual StateEntity State { get; set; }

        public virtual ICollection<ITRegisterEntity> ITRegisters { get; set; }
    }
}
