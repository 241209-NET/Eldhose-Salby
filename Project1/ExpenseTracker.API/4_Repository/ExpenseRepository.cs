using ExpenseTracker.API.Data;

namespace ExpenseTracker.API.Repository;

public class ExpenseRepository : IExpenseRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public ExpenseRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;
    
}