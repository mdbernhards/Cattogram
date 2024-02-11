using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface IFollowerQueryLogic
    {
        List<Follower> GetFollowers();

        Follower? GetFollower(int id);

        void CreateFollower(Follower follower);
    }
}