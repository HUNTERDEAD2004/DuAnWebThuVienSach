using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Category : EntityBase
    {
        public Guid CategoryId { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 255 characters.")]
        public string Name { get; set; }

        //Khoas ngoai 
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
