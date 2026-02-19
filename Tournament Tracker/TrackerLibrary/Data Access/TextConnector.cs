using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Data_Access;
using TrackerLibrary.Models;
namespace TrackerLibrary.DataAccess.TextConnector
{
    public class TextConnector : IDataConnection
    {   // TODO - wire up the CreatePrize for the text files
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
    }
}
