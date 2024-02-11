// Models/Posts.cs

using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}