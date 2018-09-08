using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Implementation.BaseClass;
using SatvaPartyRegister.Utility.Contract;

namespace SatvaPartyRegister.Repository.Implementation
{
    public class ITRegisterRepository : GenericRepository<ITRegisterEntity>
        , IITRegisterRepository
    {
        public ITRegisterRepository(IDataContext dataContext
            , ITenantProvider tenantProvider)
            : base(dataContext, tenantProvider)
        {
        }
    }
}
