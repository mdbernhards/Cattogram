// Models/Users.cs

using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cattogram.Server.Database.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; }
        [Required]
        [MaxLength(100)]
        public string Role { get; set; }
        [Required]
        [MaxLength(100)]
        public TimestampAttribute CreatedAt { get; set; }
    }
}




