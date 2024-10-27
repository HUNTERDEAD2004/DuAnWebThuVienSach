using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BorrowBooksDetail : EntityBase
    {
        public Guid BorrowBooksDetailId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BorrowBooksId { get; set; }

        [Range(1, 99, ErrorMessage = "Quantity must be between 1 and 99 Book.")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public double Price { get; set; } // Giá

        // Khóa ngoại

        // n - 1
        public virtual BorrowBooks BorrowBooks { get; set; }

        public virtual Book Book { get; set; }
    }
}
