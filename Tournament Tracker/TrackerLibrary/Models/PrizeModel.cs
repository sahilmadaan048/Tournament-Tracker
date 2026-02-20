using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
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

            decimal prizePercentageValue = 0;
            decimal.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = (double)prizePercentageValue;
        }

        /// <summary>
        /// The unique identifier for the proze
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// represnts the name of the prize
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// represnts the number of the place that this prize represents. for example 1 for the first place, 2 for the second place, etc.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// represnts the amount of money that this prize is worth.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// represents the percentage of the total prize pool that this prize is worth. for example 0.5 for 50% of the total prize pool.
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
