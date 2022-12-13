using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        public string statepath = "C:\\Program Files (x86)\\EasySave\\logjson\\state_log.json";
        public string dailypath = "C:\\Program Files (x86)\\EasySave\\logjson\\daily_log.json";

        //
        // ATTRIBUTE FOR DAILYLOG
        //

        public class Dailylogsave
        {
            public string Name;
            public string SourceFilePath;
            public string TargetFilePath;
            public string destPath;
            public long FileSize;
            public string FileTransferTime;
            public DateTime Time;

            public Dailylogsave() // Constructore without parameters is nessecery for System.Text.Json.JsonSerializer.Deserialize or it can't handle execption
            {
            }
            public Dailylogsave(string Name, string SourceFile, string TargetFile, long FileSize, string FileTransferTime)
            {
                this.Name = Name;
                this.SourceFilePath = SourceFile;
                this.TargetFilePath = TargetFile;
                this.destPath = "";
                this.FileSize = FileSize;
                this.FileTransferTime = FileTransferTime;
                this.Time = DateTime.Now;
            }
        }


        //
        // METHOD FOR DAILYLOG
        // 

        // GET list of Dailylogsave object from JSON file 
        public List<Dailylogsave> OpenDailyJSON()
        {
            string json = File.ReadAllText(this.dailypath);
            return JsonConvert.DeserializeObject<List<Dailylogsave>>(json, new JsonSerializerSettings { DateFormatString = "dd/MM/yyyy HH:mm:ss" });
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
            public long TotalFilesSize;
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
        

        // GET first save element that matche with name in JSON file and input name
        public Statelogsave OpenSaveStateJSON(string name)
        {
            return OpenStateJSON().Find(save => save.Name == name);
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
        public string ListSave()
        {
            var list = OpenStateJSON();

            if (list.Count == 0)
            {
                return "no current save create a save with: creatsave";
            }
            else
            {
                string output = "List of Saves:\n";
                foreach (var save in list)
                {
                    output += save.Name + "\n";
                }
                return output;
            }
        }

        public string putstateindailylog(Statelogsave save, string watch, long size)
        {
            var list = OpenStateJSON();
            var item = list.Find(x => x.Name == save.Name);
            list.Remove(item);
            WriteStateJSON(list);

            var dailylist = OpenDailyJSON();
            Dailylogsave dailylog = new Dailylogsave(save.Name, save.SourceFilePath, save.TargetFilePath, size, watch);
            dailylist.Add(dailylog);
            WriteDailyJSON(dailylist);





            return "Save job named --> " + save.Name + " done \n";
        }
    }




}
