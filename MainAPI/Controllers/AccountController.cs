using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace MainAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class AccountController(AccountService accountService)
{
    [HttpGet("get-customers")]
    public async Task<List<Accounts>> GetCustomersAsync()
    {
        return await accountService.GetAccountsAsync();
    }
    [HttpPost("add-customer")]
    public async Task AddCustomerAsync(Accounts account)
    {
        await accountService.AddAccountAsync(account);
    }
    [HttpPut("update-customer")]
    public async Task UpdateCustomerAsync(Accounts account)
    {
        await accountService.UpdateAccountAsync(account);
    }
    [HttpDelete("delete-customer")]
    public async Task DeleteCustomerAsync(int id)
    {
        await accountService.DeleteAccountAsync(id);
    }
}
