using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public interface IUserRepository
{
    User CreateUser(User newUser);
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int UserId);
}

public interface IExpenseService
{

}