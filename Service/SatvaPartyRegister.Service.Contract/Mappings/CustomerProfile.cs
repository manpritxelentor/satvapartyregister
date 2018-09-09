using AutoMapper;
using SatvaPartyRegister.Domain;
using SatvaPartyRegister.Model;

namespace SatvaPartyRegister.Service.Contract.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerEntity, CustomerListModel>()
                .ForMember(dest => dest.CustomerType, opt => opt.MapFrom(src => src.CustomerType.LookupName))
                .ForMember(dest => dest.AccountantName, opt => opt.MapFrom(src => src.Accountant.Name))
                .ForMember(dest => dest.AdvocateName, opt => opt.MapFrom(src => src.Advocate.Name));
        }
    }
}
