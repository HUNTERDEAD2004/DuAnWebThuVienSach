using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class PurchaseBooks : EntityBase
    {
        public Guid PurchaseBooksId { get; set; }

        public Guid UserId { get; set; }

        //Khoas ngoai
        public virtual User User { get; set; }

        public virtual ICollection<PurchaseBooksDetail> PurchaseBooksDetails { get; set; }
    }
}
