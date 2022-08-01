using Instagram.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Domain.Entities.Posts
{
    public class Comment : BaseEntity
    {
        public string Context { get; set; }

        public Guid? UserId { get; set; }
        public virtual User User { get; set; }

        public Guid? PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
