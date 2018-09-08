using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SatvaPartyRegister.Service.Contract
{
    public interface IITRegisterService
    {
        IQueryable<ITRegisterListModel> GetAll();
    }
}
