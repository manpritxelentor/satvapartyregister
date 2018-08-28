using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Service.Contract;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SatvaPartyRegister.Service.Implementation
{
    public class FinancialYearService : IFinancialYearService
    {
        private readonly IFinancialYearRepository _financialYearRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDataMapper _dataMapper;

        public FinancialYearService(IFinancialYearRepository financialYearRepository
            , IUnitOfWork unitOfWork
            , IDataMapper dataMapper)
        {
            _financialYearRepository = financialYearRepository;
            _unitOfWork = unitOfWork;
            _dataMapper = dataMapper;
        }

        public IQueryable<FinancialYearListModel> GetAll()
        {
            return _dataMapper.Project<FinancialYearEntity, FinancialYearListModel>
                (_financialYearRepository.TableNoTracking);
        }
    }
}
