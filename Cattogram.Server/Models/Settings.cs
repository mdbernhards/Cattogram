namespace Cattogram.Server.Models
{
    public class Settings
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        public List<Post>? Posts { get; set; }
    }
}