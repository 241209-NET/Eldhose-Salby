using ExpenseTracker.API.Data;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public class ExpenseRepository : IExpenseRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public ExpenseRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;

    public IEnumerable<Expense> GetAllExpenses()
    {
        return _expenseTrackerContext.Expenses.ToList();
    }
}