using System;
using System.Collections.Generic;


namespace EasySaveVersion1.View
{
    public class console
    {
        private List<string> cmd;
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


        private void Setcmd() {
            string[] data = Console.ReadLine().Split(' ');
            this.cmd = new List<string>(data);
        }

        private void Setcmdlist(List<string> data)
        {
            this.cmd = data;
        }

        private List<string> Getcmd() {
            return this.cmd;
        }




        public List<string> shell(string databackformmodel)
        {
            if (this.message == true)
            {
                Console.WriteLine(this.welcomemessage);
                this.message = false;
            }
            
                Console.WriteLine(databackformmodel);
            

            // ask user for command to put in attribut
            Setcmd();

            // check command in attribut to see if it match a know command
            allcmd();

            // return this command to controller
            return Getcmd();
        }





        private void allcmd()
        {
            switch (this.cmd[0])
            {
                case "help":
                    Console.Write(help());
                    break;

                case "createsave":
                    Console.Write(createsave());
                    Setcmdlist(this.cmd);
                    break;

                case "save":
                    Console.Write(save());
                    Setcmdlist(this.cmd);
                    return;

                case "saveall":
                    Console.Write(saveall());
                    Setcmdlist(this.cmd);
                    return;

                case "listsave":
                    Console.Write(listsave());
                    Setcmdlist(this.cmd);
                    return;

                case "logdaily":
                    Setcmdlist(this.cmd);
                    return;

                case "logstate":
                    Setcmdlist(this.cmd);
                    return;

                case "exit":
                    Console.Write(exit());
                    Setcmdlist(this.cmd);
                    return;

                default:
                    Console.Write($"No Command found named {this.cmd[0]}\n");
                    break;
            }
            return;
        }




        private string help()
        {
            return "\nhelp -- show this help message \ncreatesave -- Create a new save job (start guide to create save)\nlistsave -- List all save job created\nsave -- Start save job  \nlogdaily -- show daily log\nlogstate -- show state log\nexit -- exit program\n";
        }
        private string createsave()
        {
            return "\nUsage: createsave name sourcefile destinationfile type( COMPLET or DIFFERENTIAL )\n";
        }
        private string save()
        {
            return "\nUsage: save name\n";
        }
        private string saveall()
        {
            return "\nUsage: saveall\n";
        }
        private string listsave()
        {
            return "\nUsage: listsave\n";
        }
        private string exit()
        {
            return "\nexit EasySave Software\n";
        }


    }
}
