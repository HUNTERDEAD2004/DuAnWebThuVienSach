﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Favorite
{
    public class FavoriteDto
    {
        public Guid FavoriteId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        public Guid BookId { get; set; }
    }
}
