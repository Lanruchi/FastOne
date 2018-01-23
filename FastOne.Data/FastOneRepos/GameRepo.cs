/*
 * STEP 4, STEP Four
 * Creat the Domain repo the services will interact with
 */
using System;
using FastOne.Data.IFastOneRepos;
using FastOne.DomainClasses.Models;

namespace FastOne.Data.FastOneRepos
{
    public class GameRepo : CrudRepo<Game>, IGameRepo
    {
        public GameRepo(DataContext context) : base(context)
        {

        }
    }
}
