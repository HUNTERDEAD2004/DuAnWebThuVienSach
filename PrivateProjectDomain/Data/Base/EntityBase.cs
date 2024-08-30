using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Base
{
    public class EntityBase : ICreatedBase, IModifiedBase , IDeletedBase
    {
        public DateTimeOffset CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool Deleted { get; set; }

        public DateTimeOffset DeletedTime { get; set; }

        public Guid? DeletedBy { get; set; }

    }
}
