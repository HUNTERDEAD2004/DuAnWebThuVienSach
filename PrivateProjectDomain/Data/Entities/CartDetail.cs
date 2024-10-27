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
    public class CartDetail : EntityBase
    {
        public Guid CartDetailId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid CartId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }

        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99 Book.")]
        public int Quantity { get; set; } // Số lượng

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double Price { get; set; } // Giá

        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than 0.")]
        public double TotalPrice { get; set; } // Tổng giá

        public bool IsPaid { get; set; } = false;

        //Khóa ngoại

        // n - 1
        public virtual Cart Cart { get; set; }

        public virtual Book Book { get; set; }
    }
}
