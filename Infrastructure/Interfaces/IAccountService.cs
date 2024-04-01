using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IAccountService
{
    public Task<List<Accounts>> GetAccountsAsync();
    public Task AddAccountAsync(Accounts account);
    public Task UpdateAccountAsync(Accounts account);
    public Task DeleteAccountAsync(int id);
}
