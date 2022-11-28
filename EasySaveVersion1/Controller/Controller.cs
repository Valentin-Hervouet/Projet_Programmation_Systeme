using System;
using System.Collections.Generic;
using System.Text;
using EasySaveVersion1.View;

namespace EasySaveVersion1.Controller
{
    public class Controller
    {


        public Controller()
        {
            View.console consoleUI = new View.console();

            string returndata = "";

            while (returndata != "exit")
            {
                returndata = consoleUI.shell();
            }

        }



    }
}
