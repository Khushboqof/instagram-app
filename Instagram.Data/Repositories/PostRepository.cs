using Instagram.Data.Contexts;
using Instagram.Data.IRepositories;
using Instagram.Domain.Entities.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Data.Repositories
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(InstagramDbContext dbContext) : base(dbContext)
        {
        }
    }
}
