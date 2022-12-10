﻿using System;
using System.Collections.Generic;



namespace EasySaveVersion1.Controller
{
    public class Controller
    {
        public Controller()
        {
            Console.Title = "EasySave 1.0";
            View.console consoleUI = new View.console();
            List<String> returndata = new List<string>();

            string databackformmodel = ""; ;

            returndata.Add("");

            while (returndata[0] != "exit")
            {

                returndata = consoleUI.shell(databackformmodel);
                databackformmodel = "";
                
                // re-write xml files from json file every time, it's bad
                Model.StateLog editjson = Model.StateLog.GetInstance();
                editjson.ConvertJsontoXML();

                // createsave command
                if (returndata[0] == "createsave" && returndata.Count == 5)
                {
                    // call the class createsave and use the others inputs as parameters
                    Model.CreateSave createsave = new Model.CreateSave();
                    databackformmodel = createsave.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                    // class createsave --> method "CreateSaveInLogFile" for logic to call checkinput & statelog
                    // class checkinput --> method "" to check if source exist  
                    // class statelog --> method "CheckNumberOfSave" that check if there is already 5 or more save
                    // class statelog --> method "writesave" that write data on State.json
                }

                // listsave command 
                if (returndata[0] == "listsave" && returndata.Count == 1)
                {
                    Model.StateLog logstate = Model.StateLog.GetInstance();
                    databackformmodel = logstate.ListSave();
                    // class statelog --> method "ListSave" read save on State.json
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
            }
        }
    }
}

