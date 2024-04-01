using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICustomerService
{
    public Task<List<Customers>> GetCustomersAsync();
    public Task AddCustomerAsync(Customers customer);
    public Task UpdateCustomerAsync(Customers customer);
    public Task DeleteCustomerAsync(int id);
}
