using BookerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookerApp.Data; 

public class AppDbContext : DbContext 
{
    private readonly AppDbContext _context;
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }

}
