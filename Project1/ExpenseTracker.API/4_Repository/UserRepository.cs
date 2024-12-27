using ExpenseTracker.API.Data;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public class UserRepository : IUserRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public UserRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;

    public User CreateUser(User newUser)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public User? GetUserById(int UserId)
    {
        throw new NotImplementedException();
    }
}