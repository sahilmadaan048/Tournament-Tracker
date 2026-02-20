using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Dapper;
using Microsoft.Data.SqlClient;
using TrackerLibrary.Data_Access;
using TrackerLibrary.Models;
namespace TrackerLibrary.DataAccess.TextConnector
{
    public class TextConnector : IDataConnection
    {   // TODO - wire up the CreatePrize for the text files
        public TournamentModel CompleteTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            // Load the text file and convert the text to a list of PersonModel
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            // Find the max ID
            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            people.Add(model);

            // convert the  people to the list of strings
            // save the list of strings to the text file
            people.SaveToPeopleFile();

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file and convert the text to a list of PrizeModel
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add the new record with the new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to list of strings        
            // sabe the list of strings to the text file
            prizes.SaveToPrizeFile();

            return model;
        }

        /// <summary>
        /// adds a new table to a text file
        /// </summary>
        /// <param name="model">The team information</param>
        /// <returns>The team information plus the unique identifier</returns>
        /// <exception cref="NotImplementedException"></exception>
        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            // find the max ID
            int currentId = 1;

            if(teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile();

            return model;
        }

        //public void CreateTournament(TournamentModel model)
        //{
        //    List<TournamentModel> tournaments = GlobalConfig.TournamentFile
        //        .FullFilePath()
        //        .LoadFile()
        //        .ConvertToTournamentModels();

        //    int currentId = 1;

        //    if (tournaments.Count > 0)
        //    {
        //        currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
        //    }

        //    model.Id = currentId;

        //    model.SaveRoundsToFile();

        //    tournaments.Add(model);

        //    tournaments.SaveToTournamentFile();

        //    TournamentLogic.UpdateTournamentResults(model);
        //}

        /// <summary>
        /// Returns a list of all people from a text file
        /// </summary>
        /// <returns>List of person information</returns>
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        /// <summary>
        /// Returns a list of all teams from a text file
        /// </summary>
        /// <returns>List of team information</returns>
        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }

        public List<TournamentModel> GetTournament_All()
        {
            throw new NotImplementedException();
        }

        TournamentModel IDataConnection.CreateTournament(TournamentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
