using System.IO;

namespace EasySaveVersion1.Model
{
    class CheckInput
    {
        public string CheckPathSourceFile(string SourceFile)
        {
            // check if input file exist or input dir exist and has file in it 
            if (File.Exists(SourceFile) || (Directory.Exists(SourceFile) && Directory.EnumerateFiles(SourceFile) != null))
            {
                return "";
            }
            else
            {
                return "Source File doesn't exist -->" + SourceFile + "\n"; 
            }
        }

        public string CheckPathTargetFile(string TargetFile)
        {
            // check if input file exist or input dir exist and has file in it 
            if (Directory.Exists(TargetFile) )
            {
                return "";
            }
            else
            {
                return "Target Diresctory doesn't exist -->" + TargetFile+ "\n"; 
            }
        }
    }
}
