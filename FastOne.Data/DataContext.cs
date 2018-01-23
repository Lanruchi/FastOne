/*
 * STEP 2, STEP TWO
 * I created the Datacontext to use my domain classes
 */
using FastOne.DomainClasses.Models;
using Microsoft.EntityFrameworkCore;

namespace FastOne.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("Filename=./9jaGamer.sqlite"); 

        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}
