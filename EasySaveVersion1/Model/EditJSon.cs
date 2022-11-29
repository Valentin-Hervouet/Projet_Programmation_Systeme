using System;
using System.Collections.Generic;
using System.Text;

namespace EasySaveVersion1.Model
{
    abstract class EditJSon
    {
        protected String DefaultPath;

        #region methods
        public void ReadJSON()
        {
            //Here is where you can ask which logfile you want to see then you print it (or open the file ?)
        }
        public void WriteJSON()
        {
            //Here is where you write in the State log if you created a save or if you execute a file
            //You write in the Daily log if you finished to execute a save.
        }
        #endregion
    }
}
