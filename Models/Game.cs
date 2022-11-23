using System.ComponentModel.DataAnnotations;

namespace RazorPagesGame.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Developer { get; set; }
        public GamePlayer Player { get; set; }
        public int Years { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
    }

    public enum GamePlayer { Singleplayer, Multiplayer, MassiveMultiplayer }
}