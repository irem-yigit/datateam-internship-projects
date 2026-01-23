using BookerApp.Models;

namespace BookerApp.Services;
public class UserService :IUserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Users>> GetAllAsync()
    {
        return await _context.Users.ToListAsync();
    }

    private static List<User> _users = new();     

    //Get all users 
    public List<User> GetAllUsers()
    {
        return _users;
    }

    //Get user by id
    public User GetUserById(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        return user;
    }

    //Add a new user
    public User CreateUser(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
        return user;
    }

    //Update a user
    public User UpdateUser(int id, User user)
    {
        var existing = _users.FirstOrDefault(u => u.Id == id);
        if (existing == null) return null;

        existing.Username = user.Username;
        existing.Email = user.Email;
        return existing;
    }

    //Delete a user by id
    public bool DeleteUser(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null) return false;

        _users.Remove(user);
        return true;
    }
}
