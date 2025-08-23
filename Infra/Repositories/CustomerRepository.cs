using System.Text.Json.Serialization;
using Domain;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Infra.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly FisioDbContext _context;

        public CustomerRepository(FisioDbContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer?> GetByCodeAsync(string code)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.Code == code);
        }

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            Console.WriteLine($"Updating customer with code: {JsonConvert.SerializeObject(customer)}");
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string code)
        {
            var customer = await _context.Customers.FindAsync(code);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
