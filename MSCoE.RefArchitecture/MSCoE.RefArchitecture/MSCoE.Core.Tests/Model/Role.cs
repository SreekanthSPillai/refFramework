using System.Collections.Generic;

namespace VH.RepoTesting.Model
{
    public class Role : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
