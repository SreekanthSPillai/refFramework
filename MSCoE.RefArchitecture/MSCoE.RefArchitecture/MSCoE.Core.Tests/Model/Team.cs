using System.Collections.Generic;

namespace MSCoE.Core.Tests.Model
{
    public class Team : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
