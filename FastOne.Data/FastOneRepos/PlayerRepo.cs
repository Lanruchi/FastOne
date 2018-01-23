using System;
using FastOne.Data.IFastOneRepos;
using FastOne.DomainClasses.Models;

namespace FastOne.Data.FastOneRepos
{
    public class PlayerRepo : CrudRepo<Player>, IPlayerRepo
    {
        public PlayerRepo(DataContext context) : base(context)
        {
        }
    }
}
