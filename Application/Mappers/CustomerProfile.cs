using AutoMapper;
using Application.Views;
using Domain;
using Application.Requests;

namespace Application.Mappers;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<Customer, CustomerView>()
            .ReverseMap();
        CreateMap<CustomerRequest, Customer>();
        CreateMap<Address, AddressView>().ReverseMap();
        CreateMap<ContactInfo, ContactInfoView>().ReverseMap();
        CreateMap<ContactInfoRequest, ContactInfo>();
        CreateMap<Customer, CustomerListView>()
            .ReverseMap();
        CreateMap<AddressRequest, Address>();
    }
}