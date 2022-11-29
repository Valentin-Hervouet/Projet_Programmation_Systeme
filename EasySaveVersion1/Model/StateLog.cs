using System;
using System.Collections.Generic;
using System.Text;

namespace EasySaveVersion1.Model
{
    class StateLog
    {
        private StateLog instance;
        private StateLog()
        {
            
        }
        public StateLog GetInstance()
        {
            if (instance == null)
            {
                instance = new StateLog();
            }
            return instance;
        }

    }
}
