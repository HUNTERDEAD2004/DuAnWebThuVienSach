using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Favorite : EntityBase
    {
        public Guid FavoriteId { get; set; }

        public Guid UserId { get; set; }

        public string BookId { get; set; } = string.Empty;

        //Khoa ngoai
        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}
