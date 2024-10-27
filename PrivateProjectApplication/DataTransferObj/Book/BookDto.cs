using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Book
{
    public class BookDto
    {
        public Guid BookId { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Title must be between 1 and 255 characters.")]
        public string Title { get; set; } = string.Empty; // Tiêu đề

        [Required(ErrorMessage = "ISBN is required.")]
        [RegularExpression(@"^(97(8|9))?\d{9}(\d|X)$", ErrorMessage = "Invalid ISBN format. It must be either 10 or 13 digits.")]
        public string ISBN { get; set; } // Mã định danh đặc biệt của sách

        public int View { get; set; } // Lượt đọc

        public List<string> ImageBook { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Selling price must be greater than 0.")]
        public double SellingPrice { get; set; }  // Giá bán

        [Range(0.01, double.MaxValue, ErrorMessage = "Rental price must be greater than 0.")]
        public double RentalPrice { get; set; } // Giá mượn

        [Required(ErrorMessage = "ID is required.")]
        public Guid? SaleId { get; set; }

        [StringLength(1000, ErrorMessage = "Description must not exceed 1000 characters.")]
        public string Description { get; set; } = string.Empty;
    }
}
