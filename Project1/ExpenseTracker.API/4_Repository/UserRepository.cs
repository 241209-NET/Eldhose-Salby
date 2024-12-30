using ExpenseTracker.API.Data;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public class UserRepository : IUserRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;
    public UserRepository(ExpenseTrackerContext expenseTrackerContext) => _expenseTrackerContext = expenseTrackerContext;

    public User CreateUser(User newUser)
    {
        //Insert into Users values(newUser)
        _expenseTrackerContext.Users.Add(newUser);
        _expenseTrackerContext.SaveChanges();
        return newUser;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _expenseTrackerContext.Users.ToList();
    }

    public User? GetUserById(int id)
    {
        return _expenseTrackerContext.Users.Find(id);
    }

    public void DeleteUserById(int id)
    {
        var user = GetUserById(id);
        _expenseTrackerContext.Users.Remove(user!);
        _expenseTrackerContext.SaveChanges();
    }
}