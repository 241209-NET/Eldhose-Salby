using ExpenseTracker.API.Data;
using ExpenseTracker.API.Model;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.API.Repository;

public class ExpenseRepository : IExpenseRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public ExpenseRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;
    
    public IEnumerable<Expense> GetAllExpenses()
    {
        return _expenseTrackerContext.Expenses
        .Include(e => e.User)
        .Include(e => e.Category)
        .ToList();
    }

    public Expense? GetExpenseById(int id)
    {
        return _expenseTrackerContext.Expenses.Find(id);
    }
    
    public Expense CreateExpense(Expense newExpense)
    {
        _expenseTrackerContext.Expenses.Add(newExpense);
        _expenseTrackerContext.SaveChanges();
        return newExpense;
    }
}