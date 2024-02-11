using Cattogram.Server.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetWebApiWithEFCodeFirst.Models
{
    public class CattoDBContext(DbContextOptions<CattoDBContext> options) : DbContext(options)
    {
        public DbSet<User> User { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Follower> Follower { get; set; }

        public DbSet<Likes> Likes { get; set; }

        public DbSet<LikeType> LikeType { get; set; }

        public DbSet<Photo> Photo { get; set; }

        public DbSet<Post> Post { get; set; }

        public DbSet<Role> Role { get; set; }
    }
}