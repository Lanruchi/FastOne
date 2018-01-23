/*
 * STEP 1, STEP One
 * I created the Domain models for my entities
 */

using System.ComponentModel.DataAnnotations;
namespace FastOne.DomainClasses.Models
{
    public class Game
    {

        public long GameId { get; set; }

        public char FirstPlayerPieceCode { get; set; }

        public string GameType { get; set; }

        public string GameStatus { get; set; }



        public Player FirstPlayer { get; set; }

        public Player SecondPlayer { get; set; }

    }
}
