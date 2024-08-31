using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectApplication.DataTransferObj.Favorite
{
    public class FavoriteDto
    {
        public Guid FavoriteId { get; set; }

        public Guid UserId { get; set; }

        public string BookId { get; set; } = string.Empty;
    }
}
