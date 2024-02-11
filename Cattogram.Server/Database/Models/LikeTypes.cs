// Models/LikeTypes.cs

using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class LikeTypes
    {
        [Key]
        public int LikeTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}