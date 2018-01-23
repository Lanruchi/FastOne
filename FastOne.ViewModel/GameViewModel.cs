using System.ComponentModel.DataAnnotations;
namespace FastOne.ViewModels
{
    public class GameViewModel
    {
        public long GameId { get; set; }

        public char FirstPlayerPieceCode { get; set; }

        public string GameType { get; set; }

        public string GameStatus { get; set; }



        public PlayerViewModel FirstPlayer { get; set; }

        public PlayerViewModel SecondPlayer { get; set; }

    }
}
