using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.View
{
    public class console
    {
        private string cmd;
        private bool message = true;
        private string welcomemessage = @"
     _____                _____                  
    |  ___|              /  ___|                 
    | |__  __ _ ___ _   _\ `--.  __ ___   _____  
    |  __|/ _` / __| | | |`--. \/ _` \ \ / / _ \ 
    | |__| (_| \__ \ |_| /\__/ / (_| |\ V /  __/ 
    \____/\__,_|___/\__, \____/ \__,_| \_/ \___| 
                     __/ |                       
                    |___/ ";



        public string shell()
        {
            if (this.message == true)
            {
                Console.WriteLine(this.welcomemessage);
                this.message = false;
            }
            getcmdfromuser();
            return allcmd();

        }


        private void getcmdfromuser()
        {
            this.cmd = Console.ReadLine();
        }

        private string allcmd()
        {
            switch (this.cmd)
            {
                case "help":
                    Console.Write(help());
                    break;

                case "createsave":
                    Console.Write(createsave());
                    return "createsave";

                case "save":
                    Console.Write(save());
                    return "save";

                case "logdaily":
                    return "logdaily";

                case "logcurrent":
                    return "logcurrent";

                case "exit":
                    Console.Write(exit());
                    return "exit";

                default:
                    Console.Write($"No Command found named {this.cmd}\n");
                    break;
            }
            return "";
        }


        private string help()
        {
            return "\nhelp -- show this help message \ncreatesave -- Create a new save job (start guide to create save)\nlistsave -- List all save job created\nsave -- Start save job  \nlogdaily -- show daily log\nlogstate -- show state log\nexit -- exit program\n";
        }

        private string createsave()
        {
            return "\nUsage: createsave name sourcefile destinationfile type( complet || differential )\n";
        }

        private string save()
        {
            return "\nUsage: save name\n";
        }


        private string exit()
        {
            return "\nexit EasySave Software\n";
        }


    }
}
