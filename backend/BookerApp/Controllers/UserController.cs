using Microsoft.AspNetCore.Mvc;
using BookerApp.Models;
using System.Runtime.Versioning;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BookerApp.Services;

namespace BookerApp.Controllers;
[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;      // Dependency Injection of UserService
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    //Get all users 
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(_userService.GetAllUsers());
    }

    //Get user by id
    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        if (user == null)
            return NotFound("User not found");
        return Ok(user);
    }

    //Add a new user
    [HttpPost]
    public IActionResult CreateUser ([FromBody] User user)
    {
        var createdUser = _userService.Create(user);
        return CreatedAtAction(nameof(GetUserById),
            new { id = createdUser.Id },
            createdUser);
    }

    //Update a user
    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] User user)
    {
        var updatedUser = _userService.Update(id, user);

        if (updatedUser == null)
            return NotFound("User not found");
        return Ok(updatedUser);
    }

    //Delete a user by id
    [HttpDelete("{id}")]
    public IActionResult DeleteUser (int id)
    {
        var isDeleted = _userService.Delete(id);

        if (!isDeleted)
            return NotFound("User not found");

        return Ok(new { message = "User deleted successfully" });
    }
}
