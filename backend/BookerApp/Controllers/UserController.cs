using Microsoft.AspNetCore.Mvc;
using BookerApp.Models;
using System.Runtime.Versioning;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookerApp.Controllers;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    //Get all users 
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new List<User>
        {
            new User { Id = 1, Username = "iremyigit", Email = "iremyigit@example.com", Password = "12345"}
        };

        return Ok(users);
    }

    //Add a new user
    [HttpPost]
    public IActionResult CreateUser ([FromBody] User user)
    {
        return Ok(new 
        {
            message = "User created",
            data = user 
        });
    }
}




