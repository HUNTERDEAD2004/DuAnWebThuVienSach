using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Voucher : EntityBase
    {
        public string VoucherCode { get; set; } = string.Empty; // Mã voucher

        public string VoucherName { get; set;} = string.Empty;

        public decimal DiscountPrice { get; set; } // Giá giảm

        public string Description { get; set; } = string.Empty;

        //Khoas ngoai
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
