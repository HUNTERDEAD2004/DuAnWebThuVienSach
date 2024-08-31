using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.PurchaseBooksDetail
{
    public class PurchaseBooksDetailDto
    {
        public Guid PurchaseBooksDetailId { get; set; }

        public Guid BookId { get; set; }

        public Guid PurchaseBooksId { get; set; }

        public int Quantity { get; set; }
    }
}
