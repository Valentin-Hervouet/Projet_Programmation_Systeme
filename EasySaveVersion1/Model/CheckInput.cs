using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Xml.Linq;

namespace EasySaveVersion1.Model
{
    class CheckInput
    {
        public CheckInput()
        {

        }
        public string CheckPath(string SourceFile)
        {
            //Return 0 if Path is correct, 1 or something else if Path is not correct
            Boolean succes = true;

            if (succes == true)
            {
                return "true";
            }
            else
            {
                return "error source file not found";
            }
        }
        public int CheckNumberFile()
        {
            //Return 0 if Number of File is under 5, 1 or something else if Number of File is 5
            return 0;
        }
    }
}
