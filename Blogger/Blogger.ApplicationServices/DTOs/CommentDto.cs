using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.ApplicationServices.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public bool IsVisible { get; set; }
    }
}
