using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Book
{
    public class BookDto
    {
        public string BookId { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public Guid ISBN { get; set; }

        public int View { get; set; }

        public double SellingPrice { get; set; }

        public double RentalPrice { get; set; }

        public string SaleId { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
