using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BookCategory : EntityBase
    {
        public Guid BookCategoryId { get; set; }

        [Required]
        public Guid BookId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        // Khóa ngoại

        // 1 - n
        public virtual Book Book { get; set; }

        public virtual Category Category { get; set; }
    }
}
