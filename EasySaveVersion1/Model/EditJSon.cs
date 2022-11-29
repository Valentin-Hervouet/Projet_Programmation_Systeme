using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        protected string DefaultPath;

        #region methods
        public void ReadJSON()
        {
            //Here is where you can ask which logfile you want to see then you print it
            Console.WriteLine("Please, specify the Log you want to read.\n State or Daily");
            string StateOrDaily = Console.ReadLine();
            string Line;
            if (StateOrDaily == "State" || StateOrDaily == "state" || StateOrDaily == "Statelog" || StateOrDaily == "StateLog" || StateOrDaily == "statelog")
            {
                try
                {
                    StreamReader sr = new StreamReader("C:\\Statelog.json");
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
                    StreamReader sr = new StreamReader("C:\\Dailylog.json");
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
            else
            {
                Console.WriteLine("This is not a word understood by EasySave");
            }
        }
        public void WriteJSON(string StateOrDaily, string TextToWrite)
        {
            //Here is where you write in the State log if you created a save or if you execute a file
            //You write in the Daily log if you finished to execute a save.
            if (StateOrDaily == "Daily" || StateOrDaily == "daily" || StateOrDaily == "Dailylog" || StateOrDaily == "DailyLog" || StateOrDaily == "dailylog")
            {
                try
                {
                    StreamWriter sw = new StreamWriter("C:\\Dailylog.json", true, Encoding.Unicode);

                    //Write things in the ()
                    sw.Write(TextToWrite);

                    sw.Close();
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
            else if (StateOrDaily == "State" || StateOrDaily == "state" || StateOrDaily == "Statelog" || StateOrDaily == "StateLog" || StateOrDaily == "statelog")
            {
                try
                {
                    StreamWriter sw = new StreamWriter("C:\\Statelog.json", true, Encoding.Unicode);

                    //Write things in the ()
                    sw.Write(TextToWrite);

                    sw.Close();
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
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
        #endregion
    }
}
