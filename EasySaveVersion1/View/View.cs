using System;
using System.Collections.Generic;
using System.Globalization;

// Ceci est un test

namespace EasySaveVersion1.View
{
    public class console
    {
        private string langue;
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

        private String welcomemessagefr = @"
         _____                                           _     ______         _ _      
        /  ___|                                         | |    |  ___|       (_) |     
        \ `--.  __ _ _   ___   _____  __ _  __ _ _ __ __| | ___| |_ __ _  ___ _| | ___ 
         `--. \/ _` | | | \ \ / / _ \/ _` |/ _` | '__/ _` |/ _ \  _/ _` |/ __| | |/ _ \
        /\__/ / (_| | |_| |\ V /  __/ (_| | (_| | | | (_| |  __/ || (_| | (__| | |  __/
        \____/ \__,_|\__,_| \_/ \___|\__, |\__,_|_|  \__,_|\___\_| \__,_|\___|_|_|\___|
                                      __/ |                                            
                                     |___/                                             ";


        public List<string> shell(string databackformmodel)
        {
            if (this.message == true)
            {
                DisplayMenu();
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



        public void shellenfr()
        {
            Console.WriteLine("Choose language fr or en ?");
            this.langue = Console.ReadLine();

            // Itterate until it's the right language
            while (this.langue != "en" && this.langue!= "fr")
            {
                Console.WriteLine("Wrong value, please enter fr or en");
                this.langue = Console.ReadLine();
            }
            Console.Clear();
        }



        private void Setcmd()
        {
            string[] data = Console.ReadLine().Split(' ');
            this.cmd = new List<string>(data);
        }

        private void Setcmdlist(List<string> data)
        {
            this.cmd = data;
        }

        private List<string> Getcmd()
        {
            return this.cmd;
        }

        private void DisplayMenu()
        {
            if (this.langue == "fr")
            {
                Console.WriteLine("SauvegardeFacile 1.1\n");
                Console.WriteLine(this.welcomemessagefr);
            }
            else
            {
                Console.WriteLine("EasySave 1.1\n");
                Console.WriteLine(this.welcomemessage);
            }




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

                case "logdailyxml":
                    Setcmdlist(this.cmd);
                    return;

                case "logstatexml":
                    Setcmdlist(this.cmd);
                    return;

                case "exit":
                    Console.Write(exit());
                    Setcmdlist(this.cmd);
                    return;

                case "clear":
                    Console.Clear();
                    DisplayMenu();
                    return;

                default:
                    Console.Write($"No Command found named {this.cmd[0]}\n");
                    break;
            }
            return;
        }




        private string help()
        {
            if(this.langue == "en")
            {
                return "\nhelp -- Show this help message \ncreatesave -- Create a new save job (start guide to create save)\nlistsave -- List all save job created\nsave -- Start save job  \nsaveall -- Save all jobs  \nlogdaily -- Show daily log in JSON\nlogstate -- Show state log in JSON\nlogdailyxml -- Show daily log in XML\nlogstatexml -- Show state log in XML\nclear -- Clear console \nexit -- Exit program\n";
            }
            else
            {
                return "\nhelp -- Afficher ce message \ncreatesave -- Creer une nouvelle sauvegarde (demarre le guide de creation de sauvegarde)\nlistsave -- Liste tous les travaux de sauvegarde crees\nsave -- Demare un travail de sauvegarde\nsaveall -- Sauvegarde tout les travaux\nlogdaily -- Affiche les \"daily log\" en JSON\nlogstate -- Affiche les \"state log\" en JSON\nlogdailyxml -- Affiche les \"daily log\" en XML\nlogstatexml -- Affiche les \"state log\" en XML\nclear -- Nettoyer la console\nexit -- Quitte le programme\n";
            }
            
        }
        private string createsave()
        {
            if (this.langue == "en")
            {
                return "\nUsage: createsave name sourcefile destinationfile type( COMPLET or DIFFERENTIAL )\n";
            }
            else
            {
                return "\nUtilisation: createsave nom cheminorigine chemindestination type( COMPLET ou DIFFERENTIAL )\n";
            }
            
        }
        private string save()
        {
            if (this.langue == "en")
            {
                return "\nUsage: save name\n";
            }
            else
            {
                return "\nUtilisation: save nom\n";
            }

        }
        private string saveall()
        {
            if (this.langue == "en")
            {
                return "\nUsage: saveall\n";
            }
            else
            {
                return "\nUtilisation: saveall\n";
            }

        }  
        private string listsave()
        {
            if (this.langue == "en")
            {
                return "\nUsage: listsave\n";
            }
            else
            {
                return "\nUtilisation: listsave\n";
            }

        }  
        private string exit()
        {
            if (this.langue == "en")
            {
                return "\nexit EasySave Software\n";
            }
            else
            {
                return "\nquitte le logiciel SauvegardeFacile\n";
            }

        }


    }
}