using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using SatvaPartyRegister.Repository.Contract;
using SatvaPartyRegister.Service.Contract;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SatvaPartyRegister.Service.Implementation
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IDataMapper _dataMapper;

        public CompanyService(ICompanyRepository companyRepository
            , IDataMapper dataMapper)
        {
            _companyRepository = companyRepository;
            _dataMapper = dataMapper;
        }

        public List<CompanyListModel> GetAll()
        {
            var data = _companyRepository.TableNoTracking;
            return _dataMapper.Project<CompanyEntity, CompanyListModel>(data)
                .ToList();
        }
    }
}
