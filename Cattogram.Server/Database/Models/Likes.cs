// Models/Likes.cs

using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Likes
    {
        [Key]
        public int LikeId { get; set; }
        [Required]
        public int LikerId { get; set; }
        [Required]
        public int PostId { get; set; }
        [Required]
        public int LikeTypeId { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}