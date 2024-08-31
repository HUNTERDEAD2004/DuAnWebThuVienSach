using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Invoice
{
    public class InvoiceDto
    {
        public Guid InvoiceId { get; set; }

        public Guid UserId { get; set; }

        public string VoucherCode { get; set; } = string.Empty;

        public double TotalPrice { get; set; }

        public string PaymentMethod { get; set; } = string.Empty;

        public string Note { get; set; } = string.Empty;
    }
}
