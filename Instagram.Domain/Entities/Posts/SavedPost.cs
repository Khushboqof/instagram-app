using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Domain.Entities.Posts
{
    public class SavedPost
    {
        public Guid? UserId { get; set; }
        public User User { get; set; }

        public Guid? PostId { get; set; }
        public Post Post { get; set; }
    }
}
