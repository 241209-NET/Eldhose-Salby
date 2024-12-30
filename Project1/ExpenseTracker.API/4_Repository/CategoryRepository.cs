using ExpenseTracker.API.Data;

namespace ExpenseTracker.API.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public CategoryRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;
    
}