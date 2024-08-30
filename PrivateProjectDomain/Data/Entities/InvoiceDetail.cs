using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class InvoiceDetail : EntityBase
    {
        public Guid InvoiceDetailId { get; set; }

        public Guid InvoiceId { get; set; }

        public string BookId { get; set; } = string.Empty;

        public int Quantity { get; set; } 

        public double TotalPrice { get; set; }

        public double UnitPrice { get; set; }

        //Khoas ngoai
        public virtual Invoice Invoice { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
