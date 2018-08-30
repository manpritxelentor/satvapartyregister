using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Model.BaseClass
{
    public abstract class BaseAuditableModel : BaseModel
    {
        public BaseAuditableModel()
        {
            IsActive = true;
        }
        public bool IsActive { get; set; }
    }

    public abstract class BaseValidateAuditableModel : BaseValidateModel
    {
        public BaseValidateAuditableModel()
        {
            IsActive = true;
        }
        public bool IsActive { get; set; }
    }
}
