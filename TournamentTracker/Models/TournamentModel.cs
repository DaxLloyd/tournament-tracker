using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class TournamentModel
    {
        /// <summary>
        /// Represents the name of the tournament.
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the amount it costs per team to enter the tournament.
        /// </summary>
        public string EntryFee { get; set; }

        /// <summary>
        /// Represents the list of teams that have entered into the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the list of prizes that can be won for that tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents the number of rounds or mataches that a tournament contains.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
