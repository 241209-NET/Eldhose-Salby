using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class ExpenseService : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository;
    private readonly IUserRepository _userRepository;
    private readonly ICategoryRepository _categoryRepository;
    public ExpenseService(IExpenseRepository expenseRepository) => _expenseRepository = expenseRepository;

    public IEnumerable<Expense> GetAllExpenses()
    {
        return _expenseRepository.GetAllExpenses();
    }
    
    public Expense CreateExpense(Expense newExpense)
    {
        var expense = _expenseRepository.CreateExpense(newExpense);
        return expense;
    }

}