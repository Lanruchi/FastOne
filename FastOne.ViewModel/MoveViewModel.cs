using System.ComponentModel.DataAnnotations;
namespace FastOne.ViewModels
{
    public class MoveViewModel
    {
        public long MoveId { get; set; }

        public long PlayerId { get; set; }
        public long GameId { get; set; }

        public int BoardRow { get; set; }
        public int BoardColumn { get; set; }
    }
}
