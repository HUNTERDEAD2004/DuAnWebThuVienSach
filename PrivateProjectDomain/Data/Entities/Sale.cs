using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Sale : EntityBase
    {
        public string SaleCode { get; set; } = string.Empty; // Mã sale

        public string SaleName { get; set; } = string.Empty;

        public decimal DiscountPrice { get; set; } // Giá giảm

        public string Description { get; set; } = string.Empty;

        //Khoas ngoai
        public virtual ICollection<Book> Books { get; set; }
    }
}
