using ExpenseTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;
    
}