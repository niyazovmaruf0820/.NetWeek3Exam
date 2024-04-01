namespace Domain.Models;

public class Accounts
{
    public int Id { get; set; }
    public string? Account_number { get; set; }
    public string? Account_type { get; set; }
    public decimal Balance { get; set; }
    public int CustomerId { get; set; }
}
