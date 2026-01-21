using BookerApp.Models;

namespace BookerApp.Services;
public interface IUserService
{
    List<User> GetAllUsers();
    User Create(User user);
    User Update(int id, User user);
    bool Delete(int id);
}