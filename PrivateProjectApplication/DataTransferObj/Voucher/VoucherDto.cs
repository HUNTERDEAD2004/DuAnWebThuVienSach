using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Voucher
{
    public class VoucherDto
    {
        public string VoucherCode { get; set; } = string.Empty;

        public string VoucherName { get; set; } = string.Empty;

        public decimal DiscountPrice { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
