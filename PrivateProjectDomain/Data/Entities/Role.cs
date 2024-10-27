using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Role : EntityBase
    {
        public Guid RoleId { get; set; }

        [StringLength(255, MinimumLength = 1, ErrorMessage = "Name must be between 1 and 255 characters.")]
        public string RoleName { get; set; }

        // Khóa ngoại

        // 1 - n
        public virtual ICollection<User> Users { get; set; }
    }
}
