using ExpenseTracker.API.DTO;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Util;

public static class Utilities
{
    public static Expense DTOToObject(ExpenseInDTO expenseDTO)
    {
        return new Expense{Amount = expenseDTO.Amount, UserId = expenseDTO.UserId, CategoryId = expenseDTO.CategoryId, Description = expenseDTO.Description};
    }
}