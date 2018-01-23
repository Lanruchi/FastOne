using System;
using FastOne.Data.IFastOneRepos;

namespace FastOne.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IGameRepo Games { get; }
        IPlayerRepo Players { get; }
        IMoveRepo Moves { get; }

        int Complete();
    }
}
