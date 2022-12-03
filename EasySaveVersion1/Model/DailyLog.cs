﻿using Newtonsoft.Json;

namespace EasySaveVersion1.Model
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
            var json = OpenStateJSON();
            return JsonConvert.SerializeObject(json, Newtonsoft.Json.Formatting.Indented); ;
        }
    }
}
