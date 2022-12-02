using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using System.Text.Json;
using System.Globalization;
using System.Linq;

//using Newtonsoft.Json;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        private string path = "/tmp/hello.json";



        public struct statelogsave
        {
            string Name;
            string SourceFilePath;
            string TargetFilePath;
            string State;
            string TypeOfSave;
            int TotalFilesToCopy;
            int TotalFilesSize;
            int NbFilesLeftToDo;
            int Progression;

            public statelogsave(string Name,string State, string SourceFile, string TargetFile, string TypeSave)
            {
                this.Name = Name;
                this.State = State;
                this.SourceFilePath = SourceFile;
                this.TargetFilePath = TargetFile;
                this.TypeOfSave = TypeSave;

            }
        };




        // output List<statelogsave> of data struct statelogsave from file path

        public List<statelogsave> ReadStateLogJSON(String path)
        {
            var output = new List<statelogsave>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                output = JsonSerializer.Deserialize<List<statelogsave>>(json);
            }
            return output;
        }


        // get number of element(nb. of save) in logstate file 
        public int NumberOfSave(String path)
        {
            var incoming = new List<statelogsave>();

            incoming = ReadStateLogJSON(path);

            return incoming.Count;
        }


        public string SimpleWrite(List<statelogsave> statelogsave, string path)
        {

            /*
            var incoming = new List<statelogsave>();

            incoming = ReadStateLogJSON(path);


            // Add any new employees
            employeeList.Add(new statelogsave()
            {
                Name = "Test Person 1"
            });

            // Update json data string
            var jsonData = JsonConvert.SerializeObject(employeeList);
            System.IO.File.WriteAllText(path, jsonData);



            var jsonString = JsonSerializer.Serialize(obj, _options);
            File.WriteAllText(fileName, jsonString);
            */


            return "error";
        }

        public string WriteSaveToJson(string Name, string SourceFile, string TargetFile, string TypeSave)
        {
            // 2 time sourceFile here for the same variable !!!
            List<statelogsave> data = ReadStateLogJSON(SourceFile);

            public struct DefaultStateLog
        {
            string Name;
            string SourceFilePath;
            string TargetFilePath;
            string State;
            string TypeOfSave;
            int TotalFilesToCopy;
            int TotalFilesSize;
            int NbFilesLeftToDo;
            int Progression;

            public Coordinate(int x, int y)
        };

        data.Add(DefaultStateLog);

            string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(path, jsonString);

            return "true";

;
        }


























    public string ReadJSON(String path)
    {
        //for read the file

        string[] lines = System.IO.File.ReadAllLines(path);
        string OutputString = "";

        foreach (string line in lines)
        {
            OutputString += line;
        }
        return OutputString;



        /*
        StreamReader Reader = new StreamReader(path);
        String Line = Reader.ReadLine();
        string OutputString = "";
        while (Line != null)
        {

            Line = Reader.ReadLine();
            OutputString += Line;
        }
        Reader.Close();
        */

    }


    public string WriteJSON(string path, string data)
    {


        /*
        var json = File.ReadAllText(path);
        //var people = JsonConvert.DeserializeObject<List<Person>>(json);
        people.Add(new Person { Id = 789, Name = "Mike", City = "ASP.NET", Street = "MVC Avenue", Zipcode = 12345 });
        json = JsonConvert.SerializeObject(people);
        File.WriteAllText(path, json);
        */

        if (true == true)
        {
            return "true " + path;
        }
        else
        {
            return "false";
        }

    }
    //Here is where you can ask which logfile you want to see then you print it
    /*Console.WriteLine("Please, specify the Log you want to read.\n State or Daily");
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
    }*/

    /*public void WriteJSON(string StateOrDaily, string TextToWrite)
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
    }*/
    //#endregion
}
}
