using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Cart
{
    public class CartDto
    {
        public Guid CartId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }
    }
}
