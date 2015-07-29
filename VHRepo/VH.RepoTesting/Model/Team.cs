using System.Collections.Generic;

namespace VH.RepoTesting.Model
{
    public class Team : BaseModel<int>
    {
        public virtual IEnumerable<User> Users { get; set; }
    }
}
