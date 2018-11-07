﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class TeamModel
    {
        /// <summary>
        /// Represents a list of players on the team.
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents the name of the team.
        /// </summary>
        public string TeamName { get; set; }
    }
}
