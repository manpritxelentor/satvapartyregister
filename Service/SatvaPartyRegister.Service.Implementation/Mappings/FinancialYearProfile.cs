using AutoMapper;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Service.Implementation.Mappings
{
    public class FinancialYearProfile : Profile
    {
        public FinancialYearProfile()
        {
            CreateMap<FinancialYearEntity, FinancialYearListModel>();
        }
    }
}
