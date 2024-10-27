using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Author
{
    public class AuthorDto
    {
        public Guid AuthorId { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "Author name must be between 2 and 100 characters.")]
        public string AuthorName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; } = string.Empty;

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1900", "1/1/2024", ErrorMessage = "DOB must be between 01/01/1900 and the current date.")]
        public DateTime DOB { get; set; } // Date Of Birth ( ngày sinh )
    }
}
