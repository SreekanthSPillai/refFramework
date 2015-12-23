using System.Collections.Generic;

namespace MSCoE.Core.Tests.Model
{
    public class Role : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
