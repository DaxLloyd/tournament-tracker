using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentTracker.Models
{
    /// <summary>
    /// Represents what the prize is for the given place.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Represents the place the team fell into.
        /// </summary>
        /// <example>
        /// 1 for 1st place, 2 for 2nd place, 3 for 3rd place, etc.
        /// </example>
        public int PlaceNumber { get; set; }
        
        /// <summary>
        ///  The friendly name for the place (second place, first runner up, etc, etc.)
        /// </summary>
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

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
