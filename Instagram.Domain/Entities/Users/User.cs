using Instagram.Domain.Commons;
using Instagram.Domain.Entities.Posts;
using Instagram.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Domain.Entities
{
    public class User : BaseEntity
    {
        [MaxLength(40)]
        public string FullName { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(40)]
        public string Username { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }

        public ICollection<UserFollowing> Followings { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<SavedPost> SavedPosts { get; set; }

    }
}
