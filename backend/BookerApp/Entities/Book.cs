using System.ComponentModel.DataAnnotations;

namespace BookerApp.Models
{
    public class Book
    {
        public long Id {get;set;}
        
        [Required(ErrorMessage = "Title cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters")]
        public String Title { get; set;}

        [Required(ErrorMessage = "Author cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Author must be between 2 and 50 characters")]
        public String Author { get; set;}

        [Required(ErrorMessage = "Publisher cannot be blank")]
        public String Publisher { get; set;}

        [Required(ErrorMessage = "Isbn cannot be blank")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "ISBN must be between 13 characters")]
        [RegularExpression(@"^[0-9X]*$", ErrorMessage = "ISBN must only contain numbers and 'X'")]
        public String Isbn { get;set;}

        [Required(ErrorMessage = "Page count cannot be blank")]
        [MinLength(1, ErrorMessage = "Page count must be at least 1")]
        public int PageCount{ get;set;}
        
        
    }
}