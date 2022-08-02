using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Service.DTOs.CommentDTOs
{
    public class CommentForCreationDto
    {
        public Guid? UserId { get; set; }

        public string Context { get; set; }

        public Guid? PostId { get; set; }
    }
}
