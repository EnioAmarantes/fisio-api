using Application.Requests;
using Application.Views;
using Infra.Repositories;
using Domain;
using AutoMapper;

namespace Application;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<CustomerView?> GetCustomerByCodeAsync(string code)
    {
        var customer = await _customerRepository.GetByCodeAsync(code);
        if (customer == null) return null;
        return _mapper.Map<CustomerView>(customer);
    }

    public async Task<IEnumerable<CustomerListView>> GetAllCustomersAsync()
    {
        var customers = await _customerRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<CustomerListView>>(customers);
    }

    public async Task<CustomerView> AddCustomerAsync(CustomerRequest customerRequest)
    {
        var customer = _mapper.Map<Customer>(customerRequest);
        await _customerRepository.AddAsync(customer);
        return _mapper.Map<CustomerView>(customer);
    }

    public async Task UpdateCustomerAsync(string code, CustomerRequest customerRequest)
    {
        var customer = await _customerRepository.GetByCodeAsync(code);
        if (customer != null)
        {
            _mapper.Map(customerRequest, customer);
            await _customerRepository.UpdateAsync(customer);
        }
    }

    public async Task DeleteCustomerAsync(string code)
    {
        await _customerRepository.DeleteAsync(code);
    }
}