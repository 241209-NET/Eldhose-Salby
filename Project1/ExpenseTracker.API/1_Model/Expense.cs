namespace ExpenseTracker.API.Model;

public class Expense 
{
    public int Id { get; set;}
    public decimal Amount { get; set;}
    public int UserId { get; set;}
    public int CategoryId { get; set;}
    public string? Description { get; set;}
}