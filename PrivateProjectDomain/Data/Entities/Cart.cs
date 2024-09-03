using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Cart : EntityBase
    {
        public Guid CartId { get; set; }

        public Guid UserId { get; set; }

        public double TotalPrice { get; set; } // Tổng giá

        //Khóa ngoại

        public virtual ICollection<CartDetail> CartDetails { get; set; }

        public virtual User User { get; set; }
    }
}
