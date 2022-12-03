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
using static EasySaveVersion1.Model.StateLog;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        public string statepath = "/Users/emili/Source/Repos/Projet_Programmation_Systeme/EasySaveVersion1/json/Sample_state.json";
        public string dailypath = "/Users/emili/Source/Repos/Projet_Programmation_Systeme/EasySaveVersion1/json/Sample_log.json";

        //
        // ATTRIBUTE FOR DAILYLOG
        //

        public class Dailylogsave
        {
            public string Name;
            public string SourceFilePath;
            public string TargetFilePath;
            public string destPath;
            public int FileSize;
            public int FileTransferTime;
            public DateTime Time;

            public Dailylogsave() // Constructore without parameters is nessecery for System.Text.Json.JsonSerializer.Deserialize or it can't handle execption
            {
            }
            public Dailylogsave(string Name, string SourceFile, string TargetFile)
            {
                this.Name = Name;
                this.SourceFilePath = SourceFile;
                this.TargetFilePath = TargetFile;
                this.destPath = "";
                this.FileSize = 0;
                this.FileTransferTime = 0;
                this.Time = DateTime.Now;
            }
        }


        //
        // METHOD FOR DAILYLOG
        // 

        // GET number of element(nb. of element) from OpenJSON method
        public int NumberOfDailyElement()
        {
            var incoming = OpenDailyJSON();
            return incoming.Count;
        }

        // GET list of Dailylogsave object from JSON file 
        public List<Dailylogsave> OpenDailyJSON()
        {
            string json = File.ReadAllText(this.dailypath);
            var list = JsonConvert.DeserializeObject<List<Dailylogsave>>(json);
            return list;
        }

        // SET list of Dailylogsave object to JSON file 
        public void WriteDailyJSON(List<Dailylogsave> list)
        {
            // Write to file
            string updatedJson = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.dailypath, updatedJson);
        }















        //
        // ATTRIBUTE FOR STATELOG
        //

        public class Statelogsave
        {
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

        //
        // METHOD FOR STATELOG
        // 

        // GET number of element(nb. of save) from OpenJSON method
        public int NumberOfStateElement()
        {
            var incoming = OpenStateJSON();
            return incoming.Count;
        }

        // GET list of Statelogsave object from JSON file 
        public List<Statelogsave> OpenStateJSON()
        {
            string json = File.ReadAllText(this.statepath);
            var list = JsonConvert.DeserializeObject<List<Statelogsave>>(json);
            return list;
        }

        // SET list of Statelogsave object to JSON file 
        public void WriteStateJSON(List<Statelogsave> list)
        {
            // Write to file
            string updatedJson = JsonConvert.SerializeObject(list, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(this.statepath, updatedJson);
        }

    }

}
