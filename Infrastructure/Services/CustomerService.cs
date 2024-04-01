namespace Infrastructure.Services;
using Domain.Models;
using global::Dapper;
using Infrastructure.Interfaces;
using Infrastructure.DataContext;

public class CustomerService(DapperContext dapperContext) : ICustomerService
{
    public async Task<List<Customers>> GetCustomersAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Customers>("select * from Customers");
        return list.ToList();
    }
    public async Task AddCustomerAsync(Customers customer)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Customers(Name,Email,PhoneNumber,Address,ProfileImage)values(@fullName,@email,@phoneNumber,@address,@profileImage)", customer);
    }
    public async Task UpdateCustomerAsync(Customers customer)
    {
        await dapperContext.Connection().ExecuteAsync("update Customers set FullName = @fullname,Email = @email,Phonenumber = @phonenumber,Address = @address,ProfileImage = @profileImage where Id = @id", customer);
    }
    public async Task DeleteCustomerAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Customers where Id = @id", new { Id = id });
    }
}
