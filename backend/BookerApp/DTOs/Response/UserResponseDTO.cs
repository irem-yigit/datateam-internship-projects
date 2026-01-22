using System.ComponentModel.DataAnnotations;

namespace BookerApp.Models
{
    public class UserResponseDTO
    {
        public long Id { get;set;}
        public String Username { get;set;}
        public String Email { get;set;}

    }
}