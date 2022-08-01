using Instagram.Data.Contexts;
using Instagram.Data.IRepositories;
using Instagram.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.Repositories
{
    public class UserFollowingRepository : GenericRepository<UserFollowing>, IUserFollowingRepository
    {
        public UserFollowingRepository(InstagramDbContext dbContext) : base(dbContext)
        {
        }
    }
}
