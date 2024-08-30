using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BookAuthor : EntityBase
    {
        public Guid BookAuthorId { get; set; }

        public Guid AuthorId { get; set; }

        public Guid BookId { get; set; }

        //Khoas ngoai
        public virtual Book Book { get; set; }

        public virtual Author Author { get; set; }
    }
}
