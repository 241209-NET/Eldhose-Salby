using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

    public User CreateUser(User newUser)
    {
        return _userRepository.CreateUser(newUser);
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public User? GetUserById(int UserId)
    {
        throw new NotImplementedException();
    }
}