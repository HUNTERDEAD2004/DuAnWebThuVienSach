using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Cart : EntityBase
    {
        public Guid CartId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        // Khóa ngoại

        // 1 - n
        public virtual ICollection<CartDetail> CartDetails { get; set; }

        // 1 - 1 
        public virtual User User { get; set; }
    }
}
