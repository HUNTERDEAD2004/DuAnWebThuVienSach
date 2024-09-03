using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class FeedBack : EntityBase
    {
        public Guid FeedBackId { get; set; }

        public Guid UserId { get; set; }

        public string BookId { get; set; } = string.Empty;

        public Decimal Rating { get; set; } // Sao đánh giá

        public string Comment { get; set; } = string.Empty; // Comment

        //Khóa ngoại
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }  
    }
}
