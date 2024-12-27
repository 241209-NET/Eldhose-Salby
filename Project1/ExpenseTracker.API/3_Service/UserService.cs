using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

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