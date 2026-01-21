using BookerApp.Models;

namespace BookerApp.Services;
public interface IUserService
{
    //User Create(User user);
    User Update(int id, User user);
    bool Delete(int id);
}
public class UserService :IUserService
{
    public User Update(int id, User user)
    {
        return user;
    }

    public bool Delete(int id)
    {
        return true;
    }
}
