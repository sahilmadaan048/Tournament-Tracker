using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// represents one team in the matchup. 
        /// It is possible to have a bye in the first round, so this may not be populated.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represents the score for this particular team. 
        /// It may not be populated until the matchup is actually played, so it is possible to have a value of 0 in this field.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represents the matchup that this team came 
        /// from as thw winning team
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
