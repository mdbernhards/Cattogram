// Models/Comments.cs

using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public int CommenterId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}