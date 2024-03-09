using Cattogram.Server.Database.Enums;

namespace Cattogram.Server.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string? Username { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateOnly BirthDate { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public Roles RoleId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime EditedAt { get; set; }
    }
}