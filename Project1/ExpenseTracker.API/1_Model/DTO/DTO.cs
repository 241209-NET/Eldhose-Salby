using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.DTO;

public class ExpenseInDTO
{
    public decimal Amount{ get; set;}
    public int UserId { get; set;}
    public int CategoryId { get; set;}
    public string? Description { get; set;}

    public Expense DTOToExpense()
    {
        return new Expense{Amount = this.Amount, UserId = this.UserId, CategoryId = this.CategoryId, Description = this.Description};
    }

}