using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int CommenterId { get; set; }

        [Required]
        public int PostId { get; set; }

        [MaxLength(1000)]
        public string? Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}