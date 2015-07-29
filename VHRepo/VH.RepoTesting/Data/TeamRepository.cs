using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VH.RepoTesting.Interfaces;
using VH.RepoTesting.Model;

namespace VH.RepoTesting.Data
{
    public class TeamRepository : SqlRepository, ITeamRepository
    {
        public TeamRepository(IDbContext context)
            : base(context)
        {

        }
        public List<User> GetUsersInTeam(int teamId)
        {
            return (from u in this.GetAll<User>()
                    where u.TeamId == teamId
                    select u).ToList();
        }
    }
}
