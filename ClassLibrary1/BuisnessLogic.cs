using DemoLibrary.Utilities;
using System;

namespace DemoLIbrary
{
    public class BuisnessLogic
    {

        public void ProcessData()
        {
            Logger logger = new Logger();
            DataAccess dataAccess = new DataAccess();

            logger.Log("Starting the processing data.");
            Console.WriteLine("Processsing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data");
        }

    }
}
