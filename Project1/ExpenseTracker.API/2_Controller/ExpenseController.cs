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

    [HttpGet("{id}")]
    public IActionResult GetExpenseById(int id)
    {
        try
        {
            var foundExpense = _expenseService.GetExpenseById(id);
            return Ok(foundExpense);
        }
        catch(Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public IActionResult CreateExpense(ExpenseInDTO newExpense)
    {
        var expense = _expenseService.CreateExpense(newExpense);
        return Ok(expense);
    }

    
}
