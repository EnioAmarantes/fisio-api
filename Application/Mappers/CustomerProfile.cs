using AutoMapper;
using Application.Views;
using Domain;
using Application.Requests;

namespace Application.Mappers;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerView>();
        CreateMap<CustomerRequest, Customer>();
        CreateMap<Address, AddressView>().ReverseMap();
        CreateMap<ContactInfo, ContactInfoView>().ReverseMap();
        CreateMap<ContactInfoRequest, ContactInfo>();
        CreateMap<Customer, CustomerListView>()
            .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.ContactInfo.PhoneNumber))
            .ForMember(dest => dest.CPF, opt => opt.MapFrom(src => src.ContactInfo.CPF))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.ContactInfo.Email))
            .ReverseMap();
        CreateMap<AddressRequest, Address>();
    }
}