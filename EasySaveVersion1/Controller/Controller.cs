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

            Boolean bol = false;

            returndata.Add("");

            while (returndata[0] != "exit")
            {

                returndata = consoleUI.shell(bol);



                // creatsave
                if (returndata[0] == "createsave" && returndata.Count == 5)
                {
                    // call the class createsave and use the others inputs as parameters
                    Model.CreateSave createsave = new Model.CreateSave();
<<<<<<< HEAD
                    bol = createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                }

                // listsave
                if (returndata[0] == "listsave" && returndata.Count == 2)
                {
                    Model.Saving save = new Model.Saving();
                    bol = save.Save(returndata[1]);
=======
                    createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                }

                // listsave
                if (returndata[0] == "save" && returndata.Count == 2)
                {
                    Model.Saving save = new Model.Saving();
                    save.Save(returndata[1]);
>>>>>>> d6ebf7a80f652cd7b0d2c2231f3af2de416bd021

                }

                // save
                if (returndata[0] == "save" && returndata.Count == 2)
                {
                    Model.Saving save = new Model.Saving();
<<<<<<< HEAD
                    bol = save.Save(returndata[1]);
=======
                    save.Save(returndata[1]);
>>>>>>> d6ebf7a80f652cd7b0d2c2231f3af2de416bd021

                }
                // saveall
                if (returndata[0] == "saveall" && returndata.Count == 1)
                {
                    Model.SaveAll saveall = new Model.SaveAll();
                    saveall.saveall();
                }
                // logdaily
                if (returndata[0] == "logdaily" && returndata.Count == 1)
<<<<<<< HEAD
                {
                    /*
                    Model.DailyLog logdaily = new Model.DailyLog();
                    logdaily.ReadDailLog();
                    */
=======
                {/*
                    Model.DailyLog logdaily = new Model.DailyLog();
                    logdaily.ReadDailLog();*/
>>>>>>> d6ebf7a80f652cd7b0d2c2231f3af2de416bd021
                }
                // logstate
                if (returndata[0] == "logstate" && returndata.Count == 1)
                {

                }


            }
        }
    }
}

