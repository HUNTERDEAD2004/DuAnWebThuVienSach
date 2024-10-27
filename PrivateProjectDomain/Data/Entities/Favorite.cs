using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class Favorite : EntityBase
    {
        public Guid FavoriteId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; } 

        //Khóa ngoại

        // n - 1
        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}
