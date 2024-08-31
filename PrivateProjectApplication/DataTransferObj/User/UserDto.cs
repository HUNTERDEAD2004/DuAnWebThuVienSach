using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.User
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public string FullName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string PassWord { get; set; } = string.Empty;

        public Guid RoleId { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}
