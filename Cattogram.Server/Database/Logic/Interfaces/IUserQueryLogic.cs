using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface IUserQueryLogic
    {
        List<User> GetUsers();

        User? GetUser(int id);

        void CreateUser(User user);
    }
}