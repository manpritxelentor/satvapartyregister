﻿using SatvaPartyRegister.Domain.BaseClass;
using System.Collections.Generic;

namespace SatvaPartyRegister.Domain
{
    public class CountryEntity:BaseAuditableTenantEntity
    {
        public CountryEntity()
        {
            States = new List<StateEntity>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public virtual ICollection<StateEntity> States { get; set; }
    }
}
