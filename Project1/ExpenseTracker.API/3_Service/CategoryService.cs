using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

    
}