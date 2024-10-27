using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.PurchaseBooks
{
    public class PurchaseBooksDto
    {
        public Guid PurchaseBooksId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid VoucherCode { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than 0.")]
        public double TotalPrice { get; set; } // Tổng giá

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 255 characters.")]
        public string PaymentMethod { get; set; } //phương thức thanh toán
    }
}
