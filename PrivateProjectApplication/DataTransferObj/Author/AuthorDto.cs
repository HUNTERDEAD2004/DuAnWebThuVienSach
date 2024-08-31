﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Author
{
    public class AuthorDto
    {
        public Guid AuthorId { get; set; }

        public string AuthorName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public DateTime DOB { get; set; }
    }
}
