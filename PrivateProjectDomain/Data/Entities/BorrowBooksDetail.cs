using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BorrowBooksDetail : EntityBase
    {
        public Guid BorrowBooksDetailId { get; set; }

        public Guid BorrowBooksId { get; set; }

        public int Quantity { get; set; }

        //Khoas ngoai
        public virtual BorrowBooks BorrowBooks { get; set; }

        public virtual Book Book { get; set; }
    }
}
