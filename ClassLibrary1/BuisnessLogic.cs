using DemoLibrary.Utilities;
using System;

namespace DemoLIbrary
{
    public class BuisnessLogic : IBuisnessLogic
    {

        ILogger logger;
        IDataAccess dataAccess;
        public BuisnessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this.logger = logger;
            this.dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            logger.Log("Starting the processing data.");
            Console.WriteLine("Processsing the data");
            dataAccess.LoadData();
            dataAccess.SaveData("ProcessedInfo");
            logger.Log("Finished processing of the data");
        }

    }
}
