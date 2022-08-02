using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Service.DTOs.CommentDTOs
{
    public class CommentForViewModel
    {
        public CommentForViewModel User { get; set; }

        public string Context { get; set; }

        public CommentForViewModel  Post { get; set; }
    }
}
