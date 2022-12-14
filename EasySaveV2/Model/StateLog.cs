using Newtonsoft.Json;
using System.IO;

namespace EasySaveV2.Model
{
    class StateLog : EditJSon
    {

        private static StateLog _instance;
        
        private StateLog()
        {
        }

        public static StateLog GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StateLog();
            }
            return _instance;
        }



        // Output content of File Statelog in this.statepath
        public string ReadJSON()
        {
            var json = OpenStateJSON();
            return JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented); ;
        }

        //use for createsave command 
        // Write Default JSON save object to Statelog file 
        public string WriteSaveToJson(string Name, string SourceFile, string TargetFile, string TypeSave)
        {
            // Get list of object from StateLog JSON
            var list = OpenStateJSON();
            // Add 1 save to the list with Statelogsave constructor
            Statelogsave save = new Statelogsave(Name, SourceFile, TargetFile, TypeSave);
            list.Add(save);
            // Write new list to JSON
            WriteStateJSON(list);
            return "Created save named -->" + save.Name + "\n";
            
        }

        public string ReadXML()
        {
            return File.ReadAllText(this.statepathxml);
        }



    }
}

