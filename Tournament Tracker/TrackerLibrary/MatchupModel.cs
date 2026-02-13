using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// represents one matchup betweenn two teams.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// represnts thw winner of this matchup. It may not be populated until the matchup is actually played.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// represents the round number for this matchup. it may not be populated until the matchup is actually played
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
