using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? LastEditTime { get; set; }

        public bool IsPositive { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public int? BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
