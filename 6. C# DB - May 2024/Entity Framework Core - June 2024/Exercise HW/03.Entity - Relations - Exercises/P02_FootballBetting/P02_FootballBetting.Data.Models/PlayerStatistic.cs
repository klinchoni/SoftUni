using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        // Here we have composite PK -> we will use Fluent API for config it
     //   [ForeignKey(nameof(Game))]
        public int GameId { get; set; }
        public virtual Game Game { get; set; } = null!;


     //   [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; } = null!;



        // Warning: Judge may not be happy with byte
        public byte ScoredGoals { get; set; }

        public byte Assists { get; set; }
        public int MinutesPlayed { get; set;}
    }
}
