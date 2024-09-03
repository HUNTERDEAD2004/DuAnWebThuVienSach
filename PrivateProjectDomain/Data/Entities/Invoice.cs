using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Invoice : EntityBase
    {
        public Guid InvoiceId { get; set; }

        public Guid UserId { get; set; }

        public string VoucherCode { get; set; } = string.Empty; // Mã voucher

        public double TotalPrice { get; set; } // Tổng giá

        public string PaymentMethod { get; set; } = string.Empty; // Phước thức thanh toán

        public string Note { get; set; } = string.Empty; // Ghi chú

        public OderStatus Status { get; set; }

        //Khoas ngoai
        public virtual User User { get; set; }

        public virtual Voucher Voucher { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }    
    }
}
