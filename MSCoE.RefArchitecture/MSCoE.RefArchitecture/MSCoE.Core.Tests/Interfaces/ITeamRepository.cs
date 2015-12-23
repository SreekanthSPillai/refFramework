using System;
namespace MSCoE.Core.Tests.Interfaces
{
    public interface ITeamRepository : IRepository
    {
        System.Collections.Generic.List<MSCoE.Core.Tests.Model.User> GetUsersInTeam(int teamId);
    }
}
