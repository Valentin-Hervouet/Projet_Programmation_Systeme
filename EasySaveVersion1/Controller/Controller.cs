using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using EasySaveVersion1.View;




namespace EasySaveVersion1.Controller
{
    public class Controller
    {
        private string[] returndata;

        public Controller()
        {
            View.console consoleUI = new View.console();

            List<String> returndata = new List<string>();

            string databackformmodel = "";

            returndata.Add("");

            while (returndata[0] != "exit")
            {

                returndata = consoleUI.shell(databackformmodel);



                // creatsave
                if (returndata[0] == "createsave" && returndata.Count == 5)
                {
                    // call the class createsave and use the others inputs as parameters
                    Model.CreateSave createsave = new Model.CreateSave();

                    databackformmodel = createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                }

                // listsave
                if (returndata[0] == "listsave" && returndata.Count == 2)
                {
                    Model.ListSave save = new Model.ListSave();
                    databackformmodel = save.listsave(returndata[1]);

                    //createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                }

                // save
                if (returndata[0] == "save" && returndata.Count == 2)
                {
                    Model.Saving save = new Model.Saving();
                    databackformmodel = save.Save(returndata[1]);
                    save.Save(returndata[1]);

                }
                // saveall
                if (returndata[0] == "saveall" && returndata.Count == 1)
                {
                    Model.SaveAll saveall = new Model.SaveAll();
                    saveall.saveall();
                }
                // logdaily
                if (returndata[0] == "logdaily" && returndata.Count == 1)
                {
                    /*
                    Model.DailyLog logdaily = new Model.DailyLog();
                    logdaily.ReadDailLog();
                    */


                }

                // logstate
                if (returndata[0] == "logstate" && returndata.Count == 1)
                {

                }




            }
        }
    }
}

