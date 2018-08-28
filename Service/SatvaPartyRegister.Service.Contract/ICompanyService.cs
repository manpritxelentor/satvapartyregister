using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;

namespace SatvaPartyRegister.Service.Contract
{
    public interface ICompanyService
    {
        List<CompanyListModel> GetAll();
        
    }
}
