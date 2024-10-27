using Domain.Data.Base;
using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class User : SpecialBase
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

        [Required(ErrorMessage = "Status is required.")]
        public EntityStatus Status { get; set; } = EntityStatus.Active;

        // Khóa ngoại

        // 1 - 1
        public virtual Cart Carts { get; set; }

        // n - 1
        public virtual Role Role { get; set; }

        // 1 - n
        public virtual ICollection<FeedBack> FeedBacks { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }

        public virtual ICollection<PurchaseBooks> PurchaseBooks { get; set; }

        public virtual ICollection<BorrowBooks> BorrowBooks { get; set; }
    }
}
