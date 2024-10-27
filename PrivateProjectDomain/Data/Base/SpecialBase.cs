using PrivateProjectDomain.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data.Base
{
    public class SpecialBase : IModifiedBase, IDeletedBase
    {
        public DateTimeOffset ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }

        public bool Deleted { get; set; } = false;

        public DateTimeOffset DeletedTime { get; set; }

        public Guid? DeletedBy { get; set; }
    }
}
