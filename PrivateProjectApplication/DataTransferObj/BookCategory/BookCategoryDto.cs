using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataTransferObj.BookCategory
{
    public class BookCategoryDto
    {
        public Guid BookCategoryId { get; set; }

        [Required]
        public Guid BookId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }
    }
}
