using System.ComponentModel.DataAnnotations;

namespace BookerApp.Models
{
    public class User
    {
        public long Id {get;set;}

        [Required(ErrorMessage = "Username cannot be blank")]
        [StringLength(50, MinimumLength = 2, 
            ErrorMessage = "Username must be between 2 and 50 characters")]
        public string Username { get;set;}
        
        [Required(ErrorMessage = "Email cannot be blank")]
        [EmailAddress]
        public string Email { get;set;}

        [Required(ErrorMessage = "Password cannot be blank")]
        [MinLength(6)]  
        public string Password { get;set;}

    }
}