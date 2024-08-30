using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BorrowBooks : EntityBase
    {
        public Guid BorrowBooksId { get; set; }

        public Guid UserId { get; set; }

        public DateTime ReturnDate { get; set; }

        public BorrowBookStatus Status { get; set; }

        //Khoas ngoai
        public virtual User User { get; set; }

        public virtual ICollection<BorrowBooksDetail> BorrowBooksDetails { get; set; }
    }
}
