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

        public Decimal Rating { get; set; }

        public string Comment { get; set; } = string.Empty;

        //Khóa ngoại
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }  
    }
}
