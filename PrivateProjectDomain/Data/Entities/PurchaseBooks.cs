using Domain.Enum;
using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class PurchaseBooks : EntityBase
    {
        public Guid PurchaseBooksId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid VoucherCode { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than 0.")]
        public double TotalPrice { get; set; } // Tổng giá

        [Required(ErrorMessage = "Status is required.")]
        public PaymentStatus PaymentMethod { get; set; }

        [Required(ErrorMessage = "Status is required.")]
        public OrderStatus Status { get; set; }

        // Khóa ngoại

        // n - 1 
        public virtual User User { get; set; }

        public virtual Voucher Voucher { get; set; }

        // 1 - n
        public virtual ICollection<PurchaseBooksDetail> PurchaseBooksDetails { get; set; }
    }
}
