using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.User
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Full name must be between 2 and 100 characters.")]
        public string FullName { get; set; } = string.Empty;

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Username must be between 2 and 100 characters.")]
        public string UserName { get; set; } = string.Empty;

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Password must be between 2 and 100 characters.")]
        public string PassWord { get; set; } = string.Empty;

        [Required]
        public Guid RoleId { get; set; }

        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2024", ErrorMessage = "DOB must be between 01/01/1900 and the current date.")]
        public DateTime DOB { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = string.Empty;
    }
}
