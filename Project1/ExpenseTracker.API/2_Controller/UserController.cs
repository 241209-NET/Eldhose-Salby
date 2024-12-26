using System.Security.Cryptography.X509Certificates;
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
    public IActionResult ReturnHello()
    {
        return Ok("Hello World");
    }
}