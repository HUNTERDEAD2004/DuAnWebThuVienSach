using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.BorrowBooksDetail
{
    public class BorrowBooksDetail
    {
        public Guid BorrowBooksDetailId { get; set; }

        public Guid BorrowBooksId { get; set; }

        public int Quantity { get; set; }
    }
}
