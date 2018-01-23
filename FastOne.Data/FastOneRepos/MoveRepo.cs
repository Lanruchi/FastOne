using System;
using FastOne.Data.IFastOneRepos;
using FastOne.DomainClasses.Models;

namespace FastOne.Data.FastOneRepos
{
    public class MoveRepo : CrudRepo<Move>, IMoveRepo
    {
        public MoveRepo(DataContext context) : base(context)
        {
        }
    }
}