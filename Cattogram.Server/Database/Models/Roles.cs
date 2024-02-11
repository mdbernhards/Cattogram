// Models/Roles.cs

using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Cattogram.Server.Database.Models
{
    public class Roles
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
    }
}




