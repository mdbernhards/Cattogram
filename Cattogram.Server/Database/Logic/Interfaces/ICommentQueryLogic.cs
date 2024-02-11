using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface ICommentQueryLogic
    {
        List<Comment> GetComments();

        Comment? GetComment(int id);

        void CreateComment(Comment comment);
    }
}