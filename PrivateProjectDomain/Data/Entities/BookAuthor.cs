using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class BookAuthor : EntityBase
    {
        public Guid BookAuthorId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "ID is required.")]
        public Guid AuthorId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }

        //Khoá ngoại

        // 1 - n
        public virtual Book Book { get; set; }

        public virtual Author Author { get; set; }
    }
}
