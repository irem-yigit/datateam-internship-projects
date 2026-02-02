using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BookerApp.Entities;
public class BookRequestDTO
{
    [Required(ErrorMessage = "Title cannot be blank")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 100 characters")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Author cannot be blank")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Author must be between 1 and 100 characters")]
    public string Author { get; set; } = null!;

    [Required(ErrorMessage = "ISBN cannot be blank")]
    [RegularExpression(@"^\d{3}-\d{10}$", ErrorMessage = "ISBN must be in the format XXX-XXXXXXXXXX")]
    public string ISBN { get; set; } = null!;

    [Range(1450, 2100, ErrorMessage = "Publication year must be between 1450 and 2100")]
    public int PublicationYear { get; set; }
}