using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Follower
    {
        [Key]
        public int FollowId { get; set; }

        [Required]
        public int FollowingUserId { get; set; }

        [Required]
        public int FollowedUserId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}