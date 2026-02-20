using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;
        /// <summary>
        /// The unique identifier for the tournament.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represents the name of the tournament. This is the only required field for a tournament to be valid.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// respresents the entry fee for the tournament.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// represnets the teams that have entered this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// represents the prizes that the tournament will give out to the winners
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represents the rounds of the tournament. Each round is a list of matchups, and each matchup has a list of entries
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
