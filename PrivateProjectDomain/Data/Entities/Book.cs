using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Book : EntityBase
    {
        public string BookId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public Guid ISBN { get; set; }

        public int View { get; set; }

        public double SellingPrice { get; set; }

        public double RentalPrice { get; set; }

        public string SaleId { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public BookStatus Status { get; set; }

        //Khóa ngoại
        public virtual CartDetail CartDetail { get; set; }

        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }

        public virtual ICollection<BookCategory> BookCategories { get; set; }

        public virtual ICollection<PurchaseBooksDetail> PurchaseBooksDetails { get; set; }

        public virtual ICollection<BorrowBooksDetail> BorrowBooksDetails { get; set; }
    }
}
