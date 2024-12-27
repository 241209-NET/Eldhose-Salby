using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;
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

    [HttpPost]
    public IActionResult CreateUser(User newUser)
    {
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteUser(string Name)
    {
        return Ok();
    }
}