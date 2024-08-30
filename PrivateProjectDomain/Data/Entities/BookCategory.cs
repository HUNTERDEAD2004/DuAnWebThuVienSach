using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BookCategory : EntityBase
    {
        public Guid BookCategoryId { get; set; }

        public Guid BookId { get; set; }

        public Guid CategoryId { get; set; }

        //Khoas ngoai
        public virtual Book Book { get; set; }

        public virtual Category Category { get; set; }
    }
}
