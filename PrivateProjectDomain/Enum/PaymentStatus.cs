using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public enum PaymentStatus
    {
        Cash = 1, // Tiền mặt
        Banking = 2, // Tiền chuyển khoản
        CreditCard = 3, // Thẻ ghi nợ
    }
}
