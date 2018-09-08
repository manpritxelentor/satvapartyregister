using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Service.Contract;
using SatvaPartyRegister.Utility.Contract;
using System.Linq;

namespace SatvaPartyRegister.Service.Implementation
{
    public class ITRegisterService : IITRegisterService
    {
        private readonly IITRegisterRepository _itRegisterRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataMapper _dataMapper;

        public ITRegisterService(IITRegisterRepository itRegisterRepository
            , IUnitOfWork unitOfWork
            , IDataMapper dataMapper)
        {
            _itRegisterRepository = itRegisterRepository;
            _unitOfWork = unitOfWork;
            _dataMapper = dataMapper;
        }

        public IQueryable<ITRegisterListModel> GetAll()
        {
            return _dataMapper.Project<ITRegisterEntity, ITRegisterListModel>
                (_itRegisterRepository.TableNoTracking);
        }
    }
}
