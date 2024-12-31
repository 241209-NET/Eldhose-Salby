using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository) => _categoryRepository = categoryRepository;

    public IEnumerable<Category>GetAllCategory()
    {
        return _categoryRepository.GetAllCategory();
    }
    
    public Category CreateCategory(Category newCategory)
    {
        var category = _categoryRepository.CreateCategory(newCategory);
        return category;
    }
}