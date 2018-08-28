using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Implementation.BaseClass;

namespace SatvaPartyRegister.Repository.Implementation
{
    public class CompanyRepository : GenericRepository<CompanyEntity>, ICompanyRepository
    {
        public CompanyRepository(IDataContext dataContext) 
            : base(dataContext)
        {
        }
    }
}
