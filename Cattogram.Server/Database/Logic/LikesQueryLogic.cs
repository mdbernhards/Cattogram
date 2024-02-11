using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class LikesQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : ILikesQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Likes> GetLikes()
        {
            return [.. _context.Likes];
        }

        public Likes? GetLikes(int id)
        {
            var likes = _context.Likes.Find(id);
            return likes;
        }

        public void CreateLike(Likes likes)
        {
            if (likes != null)
            {
                _context.Likes.Add(likes);
                _context.SaveChanges();
            }
        }
    }
}