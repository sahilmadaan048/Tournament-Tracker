using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// gives us the unique identier for the matchup
        /// </summary>
        public int Id { get; set; }
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
