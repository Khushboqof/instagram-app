using Instagram.Domain.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Domain.Entities.Posts
{
    public class Post : BaseEntity
    {
        [MaxLength(100)]
        public string Hashtags { get; set; } = string.Empty;

        [MaxLength(30)]
        public string Title { get; set; } = string.Empty;

        public string Media { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Mark { get; set; }

        public Guid? UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<SavedPost> SavedPosts { get; set; }
    }
}
