using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface ILikesQueryLogic
    {
        List<Likes> GetLikes();

        Likes? GetLikes(int id);

        void CreateLike(Likes likes);
    }
}