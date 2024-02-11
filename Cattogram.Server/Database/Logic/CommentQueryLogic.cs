using Cattogram.Server.Database.Logic.Interfaces;
using Cattogram.Server.Database.Models;
using DotnetWebApiWithEFCodeFirst.Models;

namespace Cattogram.Server.Database.Logic
{
    public class CommentQueryLogic(
        CattoDBContext dbContext,
        IWebHostEnvironment appEnvironment) : ICommentQueryLogic
    {
        private readonly CattoDBContext _context = dbContext;
        private readonly IWebHostEnvironment _appEnvironment = appEnvironment;

        public List<Comment> GetComments()
        {
            return [.. _context.Comment];
        }

        public Comment? GetComment(int id)
        {
            var comment = _context.Comment.Find(id);
            return comment;
        }

        public void CreateComment(Comment comment)
        {
            if (comment != null)
            {
                _context.Comment.Add(comment);
                _context.SaveChanges();
            }
        }
    }
}