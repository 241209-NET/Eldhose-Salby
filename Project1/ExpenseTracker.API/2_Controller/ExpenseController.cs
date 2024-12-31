using ExpenseTracker.API.Model;
using ExpenseTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]

public class ExpenseController : ControllerBase
{
    private readonly IExpenseService _expenseService;
    public ExpenseController(IExpenseService expenseService) => _expenseService = expenseService;

    [HttpGet]
    public IActionResult GetAllExpenses()
    {
        var expenseList = _expenseService.GetAllExpenses();
        return Ok(expenseList);
    }

    [HttpPost]
    public IActionResult CreateExpense(Expense newExpense)
    {
        var expense = _expenseService.CreateExpense(newExpense);
        return Ok(expense);
    }

    
}
