using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    class CheckInput
    {
        public CheckInput()
        {

        }
        public int CheckPath()
        {
            //Return 0 if Path is correct, 1 or something else if Path is not correct
            return 0;
        }
        public int CheckNumberFile()
        {
            //Return 0 if Number of File is under 5, 1 or something else if Number of File is 5
            return 0;
        }
    }
}
