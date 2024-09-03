using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Enum
{
    public enum BorrowBookStatus
    {
        OnLoan = 1, // Đang mượn
        LoanCancel = 2, // Hủy mượn
        Overdue = 3, // Quá hạn
    }
}
