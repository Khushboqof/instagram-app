using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Service.DTOs.LikeDTOs
{
    public class LikeForCreationDto
    {
        public Guid? UserId { get; set; }

        public Guid? PostId { get; set; }
    }
}
