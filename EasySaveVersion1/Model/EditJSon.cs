using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml;
using System.Text.Json;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

//using Newtonsoft.Json;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        private string path = "/Users/emili/Source/Repos/Projet_Programmation_Systeme/EasySaveVersion1/json/Sample_state.json";


   

    public class Statelogsave{
            public string Name;
            public string SourceFilePath;
            public string TargetFilePath;
            public string State;
            public string TypeOfSave;
            public int TotalFilesToCopy;
            public int TotalFilesSize;
            public int NbFilesLeftToDo;
            public int Progression;

            public Statelogsave() // Constructore without parameters is nessecery for System.Text.Json.JsonSerializer.Deserialize or it can't handle execption
            {
            }
            public Statelogsave(string Name, string SourceFile, string TargetFile, string TypeSave)
            {
                this.Name = Name;
                this.SourceFilePath = SourceFile;
                this.TargetFilePath = TargetFile;
                this.State = "NOTACTIVE";
                this.TypeOfSave = TypeSave;
                this.TotalFilesToCopy = 0;
                this.TotalFilesSize = 0;
                this.NbFilesLeftToDo = 0;
                this.Progression = 0;
            }
        }
        



        // output List<statelogsave> of data struct statelogsave from file path

        public List<Statelogsave> ReadStateLogJSON(String path)
        {
            var output = new List<Statelogsave>();

            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                output = System.Text.Json.JsonSerializer.Deserialize<List<Statelogsave>>(json);
            }

            return output;
        }


        // get number of element(nb. of save) in logstate file 
        public int NumberOfSave()
        {
            var incoming = new List<Statelogsave>();

            incoming = ReadStateLogJSON(this.path);

            return incoming.Count;
        }


        public string SimpleWrite(List<Statelogsave> statelogsave, string path)
        {
            foreach (Statelogsave data in statelogsave)
            {
                Console.WriteLine(data.Name);
            }

            return "error";
        }

        public string WriteSaveToJson(string Name, string SourceFile, string TargetFile, string TypeSave)
        {

            string json = File.ReadAllText(path);
            
            Statelogsave save = new Statelogsave(Name, SourceFile, TargetFile, TypeSave);

            var list = JsonConvert.DeserializeObject<List<Statelogsave>>(json);
            new List<Statelogsave>();

            list.Add(save);

            // Write to file
            string updatedJson = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, updatedJson);

            return "Created save named -->" + save.Name + "\n";         
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
