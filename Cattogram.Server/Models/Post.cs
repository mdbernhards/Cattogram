namespace Cattogram.Server.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public int UserId { get; set; }

        public string? Title { get; set; }

        public string? Text { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime EditedAt { get; set; }
    }
}
