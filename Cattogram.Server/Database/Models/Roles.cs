using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}