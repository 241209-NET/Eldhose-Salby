using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Service;

public interface IUserService
{
    User CreateUser(User newUser);
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User? DeleteUserById(int id);
    
    
}

public interface IExpenseService
{

}