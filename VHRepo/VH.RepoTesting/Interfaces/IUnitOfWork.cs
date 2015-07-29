using System;
namespace VH.RepoTesting.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
