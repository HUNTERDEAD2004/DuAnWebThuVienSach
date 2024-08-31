using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Cart
{
    public class CartDto
    {
        public Guid CartId { get; set; }

        public Guid UserId { get; set; }

        public double TotalPrice { get; set; }  
    }
}
