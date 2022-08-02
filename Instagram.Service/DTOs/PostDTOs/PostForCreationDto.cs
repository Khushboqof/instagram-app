using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Service.DTOs.PostDTOs
{
    public class PostForCreationDto
    {
        [MaxLength(100)]
        public string Hashtags { get; set; } = string.Empty;

        [MaxLength(30)]
        public string Title { get; set; } = string.Empty;

        public string Media { get; set; } = string.Empty;

        [MaxLength(50)]
        public string Mark { get; set; }

        public Guid? UserId { get; set; }
    }
}
