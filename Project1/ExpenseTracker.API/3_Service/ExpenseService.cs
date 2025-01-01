using ExpenseTracker.API.DTO;
using ExpenseTracker.API.ExpenseException;
using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;
using ExpenseTracker.API.Util;
using Microsoft.AspNetCore.Http.HttpResults;

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

    public Expense? GetExpenseById(int id)
    {
        var foundExpense = _expenseRepository.GetExpenseById(id);
        if(foundExpense is null) throw new NoExpenseException("That expense does not exist");
        return foundExpense;
    }
    
    public Expense CreateExpense(ExpenseInDTO newExpense)
    {
        Expense fromDTO = newExpense.DTOToExpense();
        Expense fromDTO2 = Utilities.DTOToObject(newExpense);
        
        var expense = _expenseRepository.CreateExpense(fromDTO);
        return expense;
    }

    
}