using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class FollowerQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IFollowerQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Follower> GetFollowers()
        {
            return [.. _context.Follower];
        }

        public Follower? GetFollower(int id)
        {
            var follower = _context.Follower.Find(id);
            return follower;
        }

        public void CreateFollower(Follower follower)
        {
            if (follower != null)
            {
                _context.Follower.Add(follower);
                _context.SaveChanges();
            }
        }
    }
}