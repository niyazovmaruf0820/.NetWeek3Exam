using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class CustomerController(CustomerService customerService) : ControllerBase
{
    [HttpGet("get-customers")]
    public async Task<List<Customers>> GetCustomersAsync()
    {
        return await customerService.GetCustomersAsync();
    }
    [HttpPost("add-customer")]
    public async Task AddCustomerAsync(Customers customer)
    {
        await customerService.AddCustomerAsync(customer);
    }
    [HttpPut("update-customer")]
    public async Task UpdateCustomerAsync(Customers customer)
    {
        await customerService.UpdateCustomerAsync(customer);
    }
    [HttpDelete("delete-customer")]
    public async Task DeleteCustomerAsync(int id)
    {
        await customerService.DeleteCustomerAsync(id);
    }
}
