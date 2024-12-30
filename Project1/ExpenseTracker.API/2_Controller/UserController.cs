using ExpenseTracker.API.Model;
using ExpenseTracker.API.Service;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.API.Controller;

[Route("api/[controller]")]
[ApiController]
public class UserController:ControllerBase
{
    private readonly IUserService _userService;
    public UserController(IUserService userService) => _userService = userService;

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var userList = _userService.GetAllUsers();
        return Ok(userList);
    }

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var findUser = _userService.GetUserById(id);
        if (findUser is null) return NotFound();
        return Ok(findUser);
    }

    [HttpPost]
    public IActionResult CreateUser(User newUser)
    {
        var user= _userService.CreateUser(newUser);
        return Ok(user);
    }

    [HttpDelete]
    public IActionResult DeleteUserById(int id)
    {
        var deleteUser = _userService.DeleteUserById(id);
        if (deleteUser is null) return NotFound();
        return Ok(deleteUser);
    }
}