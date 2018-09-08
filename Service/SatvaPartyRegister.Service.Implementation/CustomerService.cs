using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Service.Contract;
using SatvaPartyRegister.Utility.Contract;
using System.Linq;

namespace SatvaPartyRegister.Service.Implementation
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataMapper _dataMapper;

        public CustomerService(ICustomerRepository customerRepository
            , IUnitOfWork unitOfWork
            , IDataMapper dataMapper)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            _dataMapper = dataMapper;
        }

        public IQueryable<CustomerListModel> GetAll()
        {
            return _dataMapper.Project<CustomerEntity, CustomerListModel>
                (_customerRepository.TableNoTracking);
        }
    }
}
