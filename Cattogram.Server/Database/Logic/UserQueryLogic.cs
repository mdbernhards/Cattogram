using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class UserQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IUserQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<User> GetUsers()
        {
            return [.. _context.User];
        }

        public User? GetUser(int id)
        {
            var user = _context.User.Find(id);
            return user;
        }

        public void CreateUser(User user)
        {
            if (user != null)
            {
                _context.User.Add(user);
                _context.SaveChanges();
            }
        }
    }
}