﻿using System;
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

            returndata.Add("");

            while (returndata[0] != "exit")
            {

                returndata = consoleUI.shell();

                // creatsave
                if (returndata[0] == "createsave" && returndata.Count == 5)
                {
                    // call the class createsave and use the others inputs as parameters
                    Model.CreateSave save = new Model.CreateSave();
                    save.CreateSaveInLogFile(returndata[1], returndata[2], returndata[3], returndata[4]);
                }

                // save
                if (returndata[0] == "save" && returndata.Count == 2)
                {

                }
                // saveall
                if (returndata[0] == "saveall" && returndata.Count == 1)
                {

                }
                // logdaily
                if (returndata[0] == "logdaily" && returndata.Count == 1)
                {

                }
                // logstate
                if (returndata[0] == "logstate" && returndata.Count == 1)
                {

                }
            }
        }
    }
}

