using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BookerApp.Models
{
    public class UserRequestDTO
    {
        [Required(ErrorMessage = "Username cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 50 characters")]
        public string Username { get;set;} = null!;

        [Required(ErrorMessage = "Email cannot be blank")]
        [EmailAddress(ErrorMessage = "Email should be valid")]
        public string Email { get;set;}

        [Required(ErrorMessage = "Password cannot be blank")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        [RegularExpression(
            @"^(?=.*[A-Z])(?=.*\d).+$",
            ErrorMessage = "Password must contain at least one uppercase letter and one number")]
        public string Password { get;set;}

    }
}