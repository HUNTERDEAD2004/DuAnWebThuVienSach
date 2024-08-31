using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.BorrowBooks
{
    public class BorrowBooksDto
    {
        public Guid BorrowBooksId { get; set; }

        public Guid UserId { get; set; }

        public DateTime ReturnDate { get; set; }
    }
}
