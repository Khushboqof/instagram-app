using Instagram.Data.Contexts;
using Instagram.Data.IRepositories;
using Instagram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(InstagramDbContext dbContext) : base(dbContext)
        {
        }
    }
}
