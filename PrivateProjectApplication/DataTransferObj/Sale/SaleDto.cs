using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Sale
{
    public class SaleDto
    {
        public string SaleCode { get; set; } = string.Empty;

        public string SaleName { get; set; } = string.Empty;

        public decimal DiscountPrice { get; set; }

        public string Description { get; set; } = string.Empty;
    }
}
