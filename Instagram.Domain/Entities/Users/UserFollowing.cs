using Instagram.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Domain.Entities.Users
{
    public class UserFollowing : BaseEntity
    {
        public Guid UserFromId { get; set; }
        public Guid UserToId { get; set; }
    }
}
