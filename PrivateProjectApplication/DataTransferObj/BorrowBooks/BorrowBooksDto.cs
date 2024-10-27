using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.BorrowBooks
{
    public class BorrowBooksDto
    {
        public Guid BorrowBooksId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid VoucherCode { get; set; }

        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/2024", "1/1/2028", ErrorMessage = "DOB must be between 01/01/2024 and the Return date.")]
        public DateTime ReturnDate { get; set; } // Ngày trả thực tế

        [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than 0.")]
        public double TotalPrice { get; set; } // Tổng giá

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 255 characters.")]
        public string PaymentMethod { get; set; }
    }
}
