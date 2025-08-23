using Application.Requests;
using Application.Views;

namespace Application;

public interface ICustomerService
{
    Task<CustomerView?> GetCustomerByCodeAsync(string code);
    Task<IEnumerable<CustomerListView>> GetAllCustomersAsync();
    Task<CustomerView> AddCustomerAsync(CustomerRequest customer);
    Task UpdateCustomerAsync(string code, CustomerRequest customer);
    Task DeleteCustomerAsync(string code);
}