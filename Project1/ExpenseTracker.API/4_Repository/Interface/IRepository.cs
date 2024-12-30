using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public interface IUserRepository
{
    User CreateUser(User newUser);
    void DeleteUserById(int id);
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
}

public interface IExpenseService
{

}