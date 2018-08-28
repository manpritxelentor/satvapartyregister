using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Domain.BaseClass
{
    public abstract class BaseAuditableEntity : BaseEntity
    {
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public byte[] RowVersion { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
