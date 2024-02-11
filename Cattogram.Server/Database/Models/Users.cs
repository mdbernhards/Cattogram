using System.ComponentModel.DataAnnotations;

namespace Cattogram.Server.Database.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Username { get; set; }

        [MaxLength(50)]
        public string? FirstName { get; set; }

        [MaxLength(50)]
        public string? LastName { get; set; }

        public DateOnly BirthDate { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        [Required]
        [MaxLength(250)]
        public string? PasswordHash { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime EditedAt { get; set; }
    }
}