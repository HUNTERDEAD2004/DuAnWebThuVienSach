using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Voucher
{
    public class VoucherDto
    {
        public Guid VoucherCode { get; set; } // Mã voucher

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 255 characters.")]
        public string VoucherName { get; set; } = string.Empty;

        public decimal DiscountPrice { get; set; } // Giá giảm

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Descrip must be between 1 and 255 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}
