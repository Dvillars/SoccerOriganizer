﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerOrganizer.Models
{
    [Table("Divisions")]
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }
        public int MaxTeams { get; set; }
        public string SkillLevel { get; set; }

    }
}
