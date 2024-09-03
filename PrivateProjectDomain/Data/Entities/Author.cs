using PrivateProjectDomain.Data.Base;
using PrivateProjectDomain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Author : EntityBase
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime DOB { get; set; } // Date Of Birth ( ngày sinh )

        public EntityStatus Status { get; set; }

        //Khoas ngoai
        public virtual ICollection<BookAuthor> BookAuthors { get; set;}
    }
}
