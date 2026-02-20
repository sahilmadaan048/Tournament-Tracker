using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The uniqidentifier for the team.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represnts the pople that are on the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// represnts the name of the team
        /// </summary>
        public string TeamName { get; set; } 
            
                 
    }
}
