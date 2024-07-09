﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using P02_FootballBetting.Data.Common;

namespace P02_FootballBetting.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.Teams = new HashSet<Team>();
            this.Players = new HashSet<Player>();
        }

        [Key]
        public int TownId { get; set; }

        [MaxLength(ValidationConstants.TownNameMaxLength)]
        public string Name { get; set; } = null!;

       
        // Country relations
        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; } = null!;


        // Teams relations
        public virtual ICollection<Team> Teams { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
