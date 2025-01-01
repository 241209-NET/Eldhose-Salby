using ExpenseTracker.API.DTO;
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

    [HttpGet("{userId}")]
    public IActionResult GetExpenseByUserId(int userId)
    {
        var expenses = _expenseService.GetExpenseByUserId(userId); 
        if (expenses == null || !expenses.Any())
        {
            return NotFound($"No expenses found for UserId: {userId}");
        }
        return Ok(expenses);
    }

    [HttpPost]
    public IActionResult CreateExpense(ExpenseInDTO newExpense)
    {
        var expense = _expenseService.CreateExpense(newExpense);
        return Ok(expense);
    }

    
}
