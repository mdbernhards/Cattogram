using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Likes
    {
        [Key]
        public int LikeId { get; set; }

        [Required]
        public int LikeTypeId { get; set; }

        [Required]
        public int LikerId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}