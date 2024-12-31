using ExpenseTracker.API.Model;
using ExpenseTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]

public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;
    
    [HttpGet]
    public IActionResult GetAllCategory()
    {
        var categoryList = _categoryService.GetAllCategory();
        return Ok(categoryList);
    }

    [HttpPost]
    public IActionResult CreateCategory(Category newCategory)
    {
        var category = _categoryService.CreateCategory(newCategory);
        return Ok(category);
    }

}