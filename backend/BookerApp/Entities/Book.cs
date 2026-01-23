using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace BookerApp.Models;

public class Book
{
    public long Id {get;set;}
    
    [Required(ErrorMessage = "Title cannot be blank")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Title must be between 2 and 50 characters")]
    public string Title { get; set;}

    [Required(ErrorMessage = "Author cannot be blank")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Author must be between 2 and 50 characters")]
    public string Author { get; set;}

    [Required(ErrorMessage = "Publisher cannot be blank")]
    public string Publisher { get; set;}

    [Required(ErrorMessage = "Isbn cannot be blank")]
    [StringLength(13, MinimumLength = 13, ErrorMessage = "ISBN must be exactly 13 characters")]
    [RegularExpression(@"^[0-9]{13}$", ErrorMessage = "ISBN must contain only digits")]
    public string Isbn { get;set;}

    [Required(ErrorMessage = "Page count cannot be blank")]
    [MinLength(1, ErrorMessage = "Page count must be at least 1")]
    public int PageCount{ get;set;}
}