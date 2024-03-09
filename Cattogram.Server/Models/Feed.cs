namespace Cattogram.Server.Models
{
    public class Feed
    {
        public int UserId { get; set; }

        public List<Post>? Posts { get; set; }
    }
}