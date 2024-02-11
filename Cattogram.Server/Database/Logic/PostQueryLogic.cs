using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class PostQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : IPostQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Post> GetPosts()
        {
            return [.. _context.Post];
        }

        public Post? GetPost(int id)
        {
            var post = _context.Post.Find(id);
            return post;
        }

        public void CreatePost(Post post)
        {
            if (post != null)
            {
                _context.Post.Add(post);
                _context.SaveChanges();
            }
        }
    }
}