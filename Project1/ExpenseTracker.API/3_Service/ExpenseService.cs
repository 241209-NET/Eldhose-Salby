using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class ExpenseService : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository;
    public ExpenseService(IExpenseRepository expenseRepository) => _expenseRepository = expenseRepository;


}