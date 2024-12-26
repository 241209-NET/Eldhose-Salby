using ExpenseTracker.API.Repository;

namespace ExpenseTracker.API.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    public UserService(IUserRepository userRepository) => _userRepository = userRepository; 
    
}