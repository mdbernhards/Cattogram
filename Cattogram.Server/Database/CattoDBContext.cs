// Models/Comments.cs

using Cattogram.Server.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetWebApiWithEFCodeFirst.Models
{
    public class CattoDBContext : DbContext
    {
        public CattoDBContext(DbContextOptions<CattoDBContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<Followers> Followers { get; set; }

        public DbSet<Likes> Likes { get; set; }

        public DbSet<LikeTypes> LikeTypes { get; set; }

        public DbSet<Photos> Photos { get; set; }

        public DbSet<Posts> Posts { get; set; }

        public DbSet<Roles> Roles { get; set; }
    }
}