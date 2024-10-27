using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Entities
{
    public class FeedBack : EntityBase
    {
        public Guid FeedBackId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Rating { get; set; } // Sao đánh giá

        public string Comment { get; set; } = string.Empty; // Comment

        // Khóa ngoại

        // n - 1
        public virtual Book Book { get; set; }

        public virtual User User { get; set; }  
    }
}
