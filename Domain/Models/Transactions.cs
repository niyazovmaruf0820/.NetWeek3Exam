namespace Domain.Models;

public class Transactions
{
    public int Id { get; set; }
    public int SenderId { get; set; }
    public int RecipientId { get; set; }
    public decimal Amount { get; set; }
    public DateTime TransactionDate { get; set; }
}
