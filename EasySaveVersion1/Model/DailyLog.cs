using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    class DailyLog
    {
        private DailyLog instance;
        private DailyLog()
        {

        }
        public DailyLog GetInstance()
        {
            if (instance == null)
            {
                instance = new DailyLog();
            }
            return instance;
        }
    }
}
