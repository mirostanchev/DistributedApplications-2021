using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public DateTime? LastUpdated { get; set; }

        public DateTime? CreatedOn { get; set; }

        public bool IsActive { get; set; }

        public bool? IsMostViewed { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
