using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Invoice
{
    public class InvoiceDetailDto
    {
        public Guid InvoiceDetailId { get; set; }

        public Guid InvoiceId { get; set; }

        public string BookId { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public double TotalPrice { get; set; }

        public double UnitPrice { get; set; }
    }
}
