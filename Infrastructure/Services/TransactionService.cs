namespace Infrastructure.Services;
using Domain.Models;
using global::Dapper;
using Infrastructure.DataContext;
using Infrastructure.Interfaces;


public class TransactionService(DapperContext dapperContext) : ITransactionService
{
    public async Task<List<Transactions>> GetTransactionsAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Transactions>("select * from Transactions");
        return list.ToList();
    }
    public async Task TransactionFunction(Transactions transaction)
    {
        await dapperContext.Connection().ExecuteAsync("update Accounts set Balance = Balance - @amount where Id = @sId", new { Amount = transaction.Amount, SId = transaction.SenderId });
        await dapperContext.Connection().ExecuteAsync("update Accounts set Balance = Balance + @amount where Id = @rId", new { Amount = transaction.Amount, RId = transaction.RecipientId });
    }
}
