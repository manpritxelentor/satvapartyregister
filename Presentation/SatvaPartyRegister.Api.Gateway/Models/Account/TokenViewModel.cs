using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Api.Gateway.Models.Account
{
    public class TokenViewModel
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public int ExpiresIn { get; set; }
    }
}
