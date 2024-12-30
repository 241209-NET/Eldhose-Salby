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

    public User? GetUserById(int id)
    {
        if(id < 1) return null;
        return _userRepository.GetUserById(id);
    }

    public User? DeleteUserById(int id)
    {
        var user = GetUserById(id);
        if(user is not null) _userRepository.DeleteUserById(id);
        return user;
    }
}