using System;
using FastOne.Data.FastOneRepos;
using FastOne.Data.IFastOneRepos;

namespace FastOne.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly DataContext _context;

        public IGameRepo Games { get; private set; }
        public IPlayerRepo Players { get; private set; }
        public IMoveRepo Moves { get; private set; }

        public UnitOfWork(DataContext context)
        {
            _context = context;

            Games = new GameRepo(_context);
            Players = new PlayerRepo(_context);
            Moves = new MoveRepo(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
