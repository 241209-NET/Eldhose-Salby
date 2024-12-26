using ExpenseTracker.API.Data;

namespace ExpenseTracker.API.Repository;

public class UserRepository : IUserRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public UserRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;
}