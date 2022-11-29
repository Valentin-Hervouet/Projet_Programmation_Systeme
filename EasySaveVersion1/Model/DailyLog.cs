using System;
using System.Collections.Generic;
using System.Text;

namespace EasySaveVersion1.Model
{
    class DailyLog
    {
        private DailyLog instance;
        private DailyLog()
        {

        }
        public DailyLog getInstance()
        {
            if (instance == null)
            {
                instance = new DailyLog();
            }
            return instance;
        }
    }
}
