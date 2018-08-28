using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using System;

namespace SatvaPartyRegister.Repository.Contract
{
    public interface ICompanyRepository : IGenericRepository<CompanyEntity>
    {
    }
}
