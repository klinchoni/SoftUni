using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P02_FootballBetting.Data.Common;

namespace P02_FootballBetting.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.PlayersStatistics = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

     [MaxLength(ValidationConstants.PlayerNameMaxLength)]
        public string Name { get; set; } = null!;

        public int SquadNumber { get; set; }

        // SQL Type for bool is bit
        // By default bool is NOT NULL, by default is required
        public bool IsInjured { get; set; }



        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; } = null!;



        // Position relations
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; } = null!;

      
        
        //[ForeignKey(nameof(Town))]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }


        // from mapping table PlayerStatistic 
        public virtual ICollection<PlayerStatistic> PlayersStatistics{ get; set; }
    }
}
