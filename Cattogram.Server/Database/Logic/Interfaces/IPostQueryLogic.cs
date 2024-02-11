using Cattogram.Server.Database.Models;

namespace Cattogram.Server.Database.Logic.Interfaces
{
    public interface IPostQueryLogic
    {
        List<Post> GetPosts();

        Post? GetPost(int id);

        void CreatePost(Post post);
    }
}