using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class CartDetail : EntityBase
    {
        public Guid CartDetailId { get; set; }

        public Guid CartId { get; set; }

        public string BookId { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public double Price { get; set; }

        //Khóa ngoại
        public virtual Cart Cart { get; set; }

        public virtual Book Book { get; set; }
    }
}
