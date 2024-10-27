using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObj.BookAuthor
{
    public class BookAuthorDto
    {
        public Guid BookAuthorId { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "ID is required.")]
        public Guid AuthorId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }
    }
}
