using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface ILikeTypeQueryLogic
    {
        List<LikeType> GetLikeTypes();

        LikeType? GetLikeType(int id);

        void CreateLikeType(LikeType likeType);
    }
}