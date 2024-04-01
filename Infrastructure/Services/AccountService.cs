namespace Infrastructure.Services;
using Domain.Models;
using global::Dapper;
using Infrastructure.Interfaces;
using Infrastructure.DataContext;

public class AccountService(DapperContext dapperContext) : IAccountService
{
    public async Task<List<Accounts>> GetAccountsAsync()
    {
        var list = await dapperContext.Connection().QueryAsync<Accounts>("select * from Accounts");
        return list.ToList();
    }
    public async Task AddAccountAsync(Accounts account)
    {
        await dapperContext.Connection().ExecuteAsync("insert into Accounts(Account_number,Account_type,Balance,CustomerId)values(@account_number,@account_type,@balance,@customerId)", account);
    }
    public async Task UpdateAccountAsync(Accounts account)
    {
        await dapperContext.Connection().ExecuteAsync("update Accounts set Account_number = @account_number,Account_type = @account_type,Balance = @balance,CustomerId = @customerId where Id = @id", account);
    }
    public async Task DeleteAccountAsync(int id)
    {
        await dapperContext.Connection().ExecuteAsync("delete from Accounts where Id = @id", new { Id = id });
    }
}
