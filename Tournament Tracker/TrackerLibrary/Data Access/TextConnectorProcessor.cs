using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using TrackerLibrary.Models;

namespace TrackerLibrary.Data_Access
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return Path.Combine(
                GlobalConfig.Configuration["FileSettings:FilePath"],
                fileName
            );
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List <PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel
                {
                    Id = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };

                output.Add(p);
            }

            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel
                {
                    Id = int.Parse(cols[0]),
                    FirstName = cols[1],
                    LastName = cols[2],
                    EmailAddress = cols[3],
                    CellPhoneNumber = cols[4]
                };
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            // Id, TeamName, list of IDs separated by 
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel
                {
                    Id = int.Parse(cols[0]),
                    TeamName = cols[1],
                };

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id },{p.PlaceNumber },{p.PlaceName },{p.PrizeAmount },{p.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id },{p.FirstName },{p.LastName },{p.EmailAddress },{p.CellPhoneNumber}");
            }
            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id },{t.TeamName },{ConvertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        public static string ConvertPeopleListToString(this List<PersonModel> people)
        {
            string output = string.Empty;

            if(people.Count == 0)
            {
                return output;
            }   

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);

            return output.Trim('|');
        }
    }
}
