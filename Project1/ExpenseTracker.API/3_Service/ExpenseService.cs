using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class ExpenseService : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository;
    public ExpenseService(IExpenseRepository expenseRepository) => _expenseRepository = expenseRepository;

    public IEnumerable<Expense> GetAllExpenses()
    {
        return _expenseRepository.GetAllExpenses();
    }
}