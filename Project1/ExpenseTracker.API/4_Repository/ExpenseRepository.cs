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

    public IEnumerable<Expense> GetExpenseByUserId(int userId)
    {
        return _expenseTrackerContext.Expenses
        .Include(e => e.User)
        .Include(e => e.Category)
        .Where(e => e.UserId == userId)
        .ToList();
    }
    
    public Expense CreateExpense(Expense newExpense)
    {
        _expenseTrackerContext.Expenses.Add(newExpense);
        _expenseTrackerContext.SaveChanges();
        return newExpense;
    }

    public Expense? DeleteExpenseById(int id)
    {
        var expense = _expenseTrackerContext.Expenses.Find(id);
        if(expense == null) return null;

        _expenseTrackerContext.Expenses.Remove(expense);
        _expenseTrackerContext.SaveChanges();
        return expense;
    }
}