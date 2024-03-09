namespace Cattogram.Server.Models
{
    public class Profile
    {
        public int UserId { get; set; }

        public List<Post>? Posts { get; set; }
    }
}