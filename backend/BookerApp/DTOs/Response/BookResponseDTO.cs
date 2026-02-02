using System.ComponentModel.DataAnnotations;
using System.Reflection;
namespace BookerApp.DTOs.Response;
public class BookResponseDTO
{
    public long Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string ISBN { get; set; } = null!;

    public int PublicationYear { get; set; }
}