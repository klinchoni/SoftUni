﻿using System.ComponentModel.DataAnnotations;
using P02_FootballBetting.Data.Common;

namespace P02_FootballBetting.Data.Models
{
    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int CountryId { get; set; }

      [MaxLength(ValidationConstants.CountryNameMaxLength)]
        public string Name { get; set; } = null!;

        // Towns relations 
        public virtual ICollection<Town> Towns { get; set; }
    }
}
