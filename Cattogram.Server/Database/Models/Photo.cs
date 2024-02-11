using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        [Required]
        public int PostId { get; set; }

        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(1000)]
        public string? PhotoURL { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}