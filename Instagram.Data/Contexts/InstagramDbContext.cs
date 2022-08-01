using Instagram.Domain.Entities;
using Instagram.Domain.Entities.Posts;
using Instagram.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.Contexts
{
    public class InstagramDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = @"Server=(localdb)\\mssqllocaldb;Database=InstagramDb;Trusted_Connection=True";
            optionsBuilder.UseSqlServer(path);
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Like> Likes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<SavedPost> SavedPosts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserFollowing> UserFollowings { get; set; }
    }
}
