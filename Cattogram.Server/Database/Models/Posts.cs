using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public int UserId { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(1000)]
        public string? Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}