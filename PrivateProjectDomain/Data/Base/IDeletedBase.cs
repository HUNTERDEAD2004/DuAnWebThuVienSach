using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateProjectDomain.Data.Base
{
    public interface IDeletedBase
    {
        public bool Deleted { get; set; }

        public DateTimeOffset DeletedTime { get; set; }

        public Guid? DeletedBy { get; set; }
    }
}
