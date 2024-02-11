// Models/Followers.cs

using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Followers
    {
        [Key]
        public int FollowingUserId { get; set; }
        [Key]
        public int FollowedUserId { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}