using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker
{
    public class PrizeModel
    {
        /// <summary>
        /// Represents the place the team fell into.
        /// </summary>
        /// <example>
        /// 1 for 1st place, 2 for 2nd place, 3 for 3rd place, etc.
        /// </example>
        public int PlaceNumber { get; set; }
        
        public string PlaceName { get; set; }
        
        /// <summary>
        /// Represents the total prize amount for the tournament.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        
        /// <summary>
        /// Represents the percentage of the given prize that the 
        /// specified place gains.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
