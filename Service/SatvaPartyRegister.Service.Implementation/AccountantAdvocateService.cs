using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Service.Contract;
using SatvaPartyRegister.Utility.Contract;
using System.Linq;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Service.Implementation
{
    public class AccountantAdvocateService : IAccountantAdvocateService
    {
        private readonly IAccountantAdvocateRepository _accountantAdvocateRepository;
        private readonly IDataMapper _dataMapper;
        private readonly IUnitOfWork _unitOfWork;

        public AccountantAdvocateService(IAccountantAdvocateRepository accountantAdvocateRepository
            , IDataMapper dataMapper
            , IUnitOfWork unitOfWork)
        {
            _accountantAdvocateRepository = accountantAdvocateRepository;
            _dataMapper = dataMapper;
            _unitOfWork = unitOfWork;
        }

        public IQueryable<AccountantAdvocateListModel> GetAll()
        {
            return _dataMapper.Project<AccountantAdvocateEntity, AccountantAdvocateListModel>
                (_accountantAdvocateRepository.TableNoTracking);
        }

        public async Task<AddUpdateAccountantAdvocateModel> GetByIdAsync(int id)
        {
            var data = await _accountantAdvocateRepository.GetByIdAsync(id);
            if (data == null)
                return null;
            return _dataMapper.Map<AccountantAdvocateEntity, AddUpdateAccountantAdvocateModel>(data);
        }

        public Task<int> InsertAsync(int userId, AddUpdateAccountantAdvocateModel model)
        {
            var entity = _dataMapper.Map<AddUpdateAccountantAdvocateModel, AccountantAdvocateEntity>(model);
            entity.CreatedBy = userId;
            _accountantAdvocateRepository.Insert(entity);
            return _unitOfWork.SaveChangesAsync();
        }

        public Task<int> UpdateAsync(int id, int userId, AddUpdateAccountantAdvocateModel model)
        {
            var entity = _accountantAdvocateRepository.GetById(id);
            if (entity == null)
                return Task.Run(() => 0);
            _dataMapper.Map<AddUpdateAccountantAdvocateModel, AccountantAdvocateEntity>(model, entity);
            entity.ModifiedBy = userId;
            _accountantAdvocateRepository.Update(entity);
            return _unitOfWork.SaveChangesAsync();
        }

        public Task<int> DeleteAsync(int id, int userId)
        {
            var entity = _accountantAdvocateRepository.GetById(id);
            if (entity == null)
                return Task.Run(() => 0);
            entity.IsDeleted = true;
            entity.ModifiedBy = userId;
            _accountantAdvocateRepository.Update(entity);
            return _unitOfWork.SaveChangesAsync();
        }
    }
}
