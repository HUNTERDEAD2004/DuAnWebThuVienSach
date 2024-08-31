using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.FeedBack
{
    public class FeedBackDto
    {
        public Guid FeedBackId { get; set; }

        public Guid UserId { get; set; }

        public string BookId { get; set; } = string.Empty;

        public Decimal Rating { get; set; }

        public string Comment { get; set; } = string.Empty;
    }
}
