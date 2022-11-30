using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    class Saving
    {
        #region methods
        public string Save( String name)
        {
            // Input
            // Sava name

            // Output
            // True or False

            Boolean succes = true;

            if (succes == true)
            {
                return "true " + name;
            }
            else
            {
                return "error";
            }

        }

        private void SaveAll()
        {

        }
        #endregion
    }
}
