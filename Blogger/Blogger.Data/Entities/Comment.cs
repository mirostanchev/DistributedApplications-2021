using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Content { get; set; }

        public DateTime? PublishDate { get; set; }

        public bool IsVisible { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
