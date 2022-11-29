using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        protected string DefaultPath;

        public void ReadJSON()
        {
            //Here is where you can ask which logfile you want to see then you print it (or open the file ?)
            Console.WriteLine("Please, specify the Log you want to read.\n State or Daily");
            string StateOrDaily = Console.ReadLine();
            string Line;
            if (StateOrDaily == "State" || StateOrDaily == "state" || StateOrDaily == "Statelog" || StateOrDaily == "StateLog" || StateOrDaily == "statelog")
            {
                try
                {
                    StreamReader sr = new StreamReader("C:\\Statelog.txt");
                    Line = sr.ReadLine();
                    while (Line != null)
                    {
                        Console.WriteLine(Line);
                        Line = sr.ReadLine();
                    }
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
            else if (StateOrDaily == "Daily" || StateOrDaily == "daily" || StateOrDaily == "Dailylog" || StateOrDaily == "DailyLog" || StateOrDaily == "dailylog")
            {
                try
                {
                    StreamReader sr = new StreamReader("C:\\Dailylog.txt");
                    Line = sr.ReadLine();
                    while (Line != null)
                    {
                        Console.WriteLine(Line);
                        Line = sr.ReadLine();
                    }
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
        }
        public void WriteJSON()
        {
            //Here is where you write in the State log if you created a save or if you execute a file
            //You write in the Daily log if you finished to execute a save.
        }
    }
}
