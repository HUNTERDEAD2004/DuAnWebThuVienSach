using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class User : EntityBase
    {
        public Guid UserId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string PassWord { get; set; } = string.Empty;

        public Guid RoleId { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public EntityStatus Status { get; set; } = EntityStatus.Active;

        //Khóa ngoại
        public virtual Cart Carts { get; set; }

        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }

        public virtual ICollection<PurchaseBooks> PurchaseBooks { get; set; }

        public virtual ICollection<BorrowBooks> BorrowBooks { get; set; }

        public virtual Role Role { get; set; }
    }
}
