using System;
namespace VH.RepoTesting.Interfaces
{
    public interface ITeamRepository : IRepository
    {
        System.Collections.Generic.List<VH.RepoTesting.Model.User> GetUsersInTeam(int teamId);
    }
}
