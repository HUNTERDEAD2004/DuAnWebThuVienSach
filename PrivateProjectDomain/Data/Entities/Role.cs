using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Role : EntityBase
    {
        public Guid RoleId { get; set; }

        public string RoleName { get; set; }

        //Khoas ngoai
        public virtual ICollection<User> Users { get; set; }
    }
}
