using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Category : EntityBase
    {
        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        //Khoas ngoai 
        public virtual ICollection<BookCategory> BookCategories { get; set; }
    }
}
