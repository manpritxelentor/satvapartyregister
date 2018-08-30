using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Utility.Contract
{
    public interface ITenantProvider
    {
        string TenantId { get; }
    }
}
