using AutoMapper;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatvaPartyRegister.Service.Contract.Mappings
{
    public class AccountantAdvocateProfile : Profile
    {
        public AccountantAdvocateProfile()
        {
            CreateMap<AccountantAdvocateEntity, AccountantAdvocateListModel>();
            CreateMap<AddUpdateAccountantAdvocateModel, AccountantAdvocateEntity>();
        }
    }
}
