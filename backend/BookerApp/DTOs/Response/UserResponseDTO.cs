using System.ComponentModel.DataAnnotations;

namespace BookerApp.Models;

public class UserResponseDTO
{
    public long Id { get;set;}
    public string Username { get;set;}
    public string Email { get;set;}
}
