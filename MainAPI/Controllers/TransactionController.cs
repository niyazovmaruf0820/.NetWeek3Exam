using System.Transactions;
using Domain.Models;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace MainAPI.Controllers;
[ApiController]
[Route("[controller]")]
public class TransactionController(TransactionService transactionService)
{
    [HttpGet("get-customers")]
    public async Task<List<Transactions>> GetCustomersAsync()
    {
        return await transactionService.GetTransactionsAsync();
    }
    [HttpOptions("do-transction")]
    public async Task TransactionFunction(Transactions transaction)
    {
        await transactionService.TransactionFunction(transaction);
    }
}
