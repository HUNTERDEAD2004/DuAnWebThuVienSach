using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class PurchaseBooksDetail : EntityBase
    {
        public Guid PurchaseBooksDetailId { get; set; }

        public Guid BookId { get; set; }

        public Guid PurchaseBooksId { get; set; }

        public int Quantity { get; set; }

        //Khoas ngoai
        public virtual PurchaseBooks PurchaseBooks { get; set; }

        public virtual Book Book { get; set; }
    }
}
