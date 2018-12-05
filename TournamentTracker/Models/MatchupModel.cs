using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents the number of entries for the tournament.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        
        /// <summary>
        /// Represents the winning team.
        /// </summary>
        public TeamModel Winner { get; set; }
        
        /// <summary>
        /// Represents the current round.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
