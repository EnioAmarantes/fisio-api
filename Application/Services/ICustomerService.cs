using Application.Requests;
using Application.Views;

namespace Application;

public interface ICustomerService
{
    Task<CustomerView?> GetCustomerByCodeAsync(Guid code);
    Task<IEnumerable<CustomerListView>> GetAllCustomersAsync();
    Task<CustomerView> AddCustomerAsync(CustomerRequest customer);
    Task UpdateCustomerAsync(Guid code, CustomerRequest customer);
    Task DeleteCustomerAsync(Guid code);
}