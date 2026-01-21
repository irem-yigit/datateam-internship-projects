using BookerApp.Models;

namespace BookerApp.Services;
public class UserService :IUserService
{
    private static List<User> _users = new();

    public List<User> GetAllUsers()
    {
        return _users;
    }

    public User Create(User user)
    {
        user.Id = _users.Count + 1;
        _users.Add(user);
        return user;
    }

    public User Update(int id, User user)
    {
        var existing = _users.FirstOrDefault(u => u.Id == id);
        if (existing == null) return null;

        existing.Username = user.Username;
        existing.Email = user.Email;
        return existing;
    }

    public bool Delete(int id)
    {
        var user = _users.FirstOrDefault(u => u.Id == id);
        if (user == null) return false;

        _users.Remove(user);
        return true;
    }

}
