﻿using System;
using System.Collections.Generic;



namespace EasySaveVersion1.Controller
{
    public class Controller
    {
        public Controller()
        {
            /*
            View.console consoleUI = new View.console();
            List<String> returndata = new List<string>();

            // string user input from View
            string databackformmodel = "";
            returndata.Add("");

            // ask user to choose language
            consoleUI.shellenfr();


            while (returndata[0] != "exit")
            {
                // pass databackformmodel to be display by the Views
                // returndata is the user input as a List of string
                returndata = consoleUI.shell(databackformmodel);
                databackformmodel = "";

                // re-write xml files from json file every time, it's bad very bad
                Model.StateLog editjson = Model.StateLog.GetInstance();
                editjson.ConvertJsontoXML();


                // createsave command
                if (returndata[0] == "createsave" && returndata.Count == 5)
                {
                    // call the class createsave and use user inputs as parameters
                    Model.CreateSave createsave = new Model.CreateSave();
                    databackformmodel = createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);

                    // CALL class inside CreateSaveInLogFile
                    // class createsave --> method "CreateSaveInLogFile" for logic to call checkinput & statelog
                    // class checkinput --> method "CheckPathSourceFile" or CheckPathTargetFile to check if source exist  
                    // class statelog --> method "WriteSaveToJson" that write data on State.json
                }

                // listsave command 
                if (returndata[0] == "listsave" && returndata.Count == 1)
                {
                    Model.StateLog logstate = Model.StateLog.GetInstance();
                    databackformmodel = logstate.ListSave();

                    // CALL class inside ListSave
                    // class statelog --> method "OpenStateJSON" read save file on State.json
                    // class statelog --> method "ListSave" return all saves
                }

                // save command
                if (returndata[0] == "save" && returndata.Count == 2)
                {
                    Model.Saving save = new Model.Saving();
                    databackformmodel = save.Save(returndata[1]);
                    // class Saving --> method "Save" copy file with data from class statelog --> method "getsave"
                }

                // saveall command
                if (returndata[0] == "saveall" && returndata.Count == 1)
                {
                    Model.Saving saveall = new Model.Saving();
                    databackformmodel = saveall.SaveAll();
                }

                // logdaily command
                if (returndata[0] == "logdaily" && returndata.Count == 1)
                {
                    Model.DailyLog logdaily = Model.DailyLog.GetInstance();
                    databackformmodel = logdaily.ReadJSON();
                }

                // logstate command
                if (returndata[0] == "logstate" && returndata.Count == 1)
                {
                    Model.StateLog logstate = Model.StateLog.GetInstance();
                    databackformmodel = logstate.ReadJSON();
                }

                // logdailyxml command
                if (returndata[0] == "logdailyxml" && returndata.Count == 1)
                {
                    Model.DailyLog logdailyxml = Model.DailyLog.GetInstance();
                    databackformmodel = logdailyxml.ReadXML();
                }

                // logstatexml command
                if (returndata[0] == "logstatexml" && returndata.Count == 1)
                {
                    Model.StateLog logstatexml = Model.StateLog.GetInstance();
                    databackformmodel = logstatexml.ReadXML();
                }
            } // end of while (returndata[0] != "exit")*/
        }
    }
}