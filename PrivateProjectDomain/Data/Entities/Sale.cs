using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Sale : EntityBase
    {
        public Guid SaleCode { get; set; } // Mã sale

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 255 characters.")]
        public string SaleName { get; set; } = string.Empty;

        public decimal DiscountPrice { get; set; } // Giá giảm

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Descrip must be between 1 and 255 characters.")]
        public string Description { get; set; } = string.Empty;

        //Khoas ngoai
        public virtual ICollection<Book> Books { get; set; }
    }
}
