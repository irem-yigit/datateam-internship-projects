using BookerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookerApp.Data; 

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
    {
    }

    public DbSet<User> Users => Set<User>();
    public DbSet<Book> Books => Set<Book>();

}
