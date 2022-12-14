using EasySaveV2.Model;
using Newtonsoft.Json;
using System.IO;

namespace EasySaveV2.Model
{
    class DailyLog : EditJSon
    {
        private static DailyLog _instance;

        private DailyLog()
        {
        }

        public static DailyLog GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DailyLog();
            }
            return _instance;
        }



        // Output content of File Statelog in this.statepath
        public string ReadJSON()
        {
            var json = OpenDailyJSON();
            return JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented); ;
        }

        public string ReadXML()
        {
            return File.ReadAllText(this.dailypathxml);
        }
        
    }
}
