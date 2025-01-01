using ExpenseTracker.API.Data;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public CategoryRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;

    public IEnumerable<Category> GetAllCategory()
    {
        return _expenseTrackerContext.Category.ToList();
    }

     public Category CreateCategory(Category newCategory)
    {
        _expenseTrackerContext.Category.Add(newCategory);
        _expenseTrackerContext.SaveChanges();
        return newCategory;
    }

    public Category? DeleteCategoryById(int id)
    {
        var category = _expenseTrackerContext.Category.Find(id);
        if(category == null) return null;

        _expenseTrackerContext.Category.Remove(category);
        _expenseTrackerContext.SaveChanges();
        return category;
    }

}