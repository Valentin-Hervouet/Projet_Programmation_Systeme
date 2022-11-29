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
                /*
                if (returndata == "createsave")
                {
                    foreach (string arg in args)
                    {
                        if (arg == "createsave")
                        {
                            // call the constructor of the CreateSave class

                        }
                        String Source = arg;
                        String Target;
                        if (Source == arg)
                        {
                            Target = arg;
                        }
                    }
                    foreach (string arg in args)
                    {
                        Console.WriteLine(arg);
                    }
                }*/
                
                /*switch (returndata)
                {
                    case "createsave": 
                        
                        // call the class createsave and use the others inputs as parameters
                        break;

                    case "help":
                        //call the help() method in the console class
                        //Console.Write(consoleUI.help());
                        break;

                    case "save": //parsing here
                        // call the saving() method in the saving class and use the others inputs as parameters of the method
                        break;
                    case "logdaily":
                        // call the logdaily class and return all the daily logs
                        break;

                    case "logcurrent":
                        //call the statelog class and return the state log
                        break;

                    case "exit":
                        // call the exit() method of the console class
                        break;

                    default:
                        Console.Write($"No Command found named {returndata}\n");
                        break;
                }*/

            }

        }



        }
}
