using System;
using EasysSaveV1.View;

namespace EasysSaveV1.Controller
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

