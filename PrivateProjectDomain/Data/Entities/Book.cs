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
    public class Book : EntityBase
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
        public Guid SaleId { get; set; }

        [StringLength(1000, ErrorMessage = "Description must not exceed 1000 characters.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Status is required.")]
        public BookStatus Status { get; set; }

        // Khóa ngoại

        // n - 1
        public virtual Sale Sale { get; set; }

        // 1 - n
        public virtual ICollection<CartDetail> CartDetails { get; set; }

        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }

        public virtual ICollection<PurchaseBooksDetail> PurchaseBooksDetails { get; set; }

        public virtual ICollection<BorrowBooksDetail> BorrowBooksDetails { get; set; }
    }
}
