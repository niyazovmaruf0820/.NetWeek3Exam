using System.Transactions;
using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ITransactionService
{
    public Task<List<Transactions>> GetTransactionsAsync();
    public Task TransactionFunction(Transactions transaction);
}
