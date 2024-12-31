using ExpenseTracker.API.DTO;
using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;
using ExpenseTracker.API.Util;

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
    
    public Expense CreateExpense(ExpenseInDTO newExpense)
    {
        Expense fromDTO = newExpense.DTOToExpense();
        Expense fromDTO2 = Utilities.DTOToObject(newExpense);
        
        var expense = _expenseRepository.CreateExpense(fromDTO);
        return expense;
    }

}