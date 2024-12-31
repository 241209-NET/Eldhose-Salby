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
}