using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    class CreateSave
    {
        #region attributes
        private String Name;
        private String SourceFile;
        private String TargetFile;
        private String TypeSave;
        #endregion

        // Notation Get & Save
        // https://learn.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/using-properties

        public string NameOfSave { get; set; }
        public string GetSourceFile() {
            return this.SourceFile;
        }
        public SetSourceFile(string SourceFile) {

        }


        public string Target { get; set; }
        public string Type { get; set; }

        public string CreateSaveInLogFile(string Name, string SourceFile, string TargetFile, string TypeSave)
        {


            Model.CheckInput InputPath = new Model.CheckInput();

            string SourceFileCheckPath;
            SourceFileCheckPath = InputPath.CheckPath(SourceFile);
            if (SourceFileCheckPath == "true")
            {
                set
            }
            else
            {
                return SourceFileCheckPath;
            }

            Boolean succes = true;

            if (succes == true)
            {
                return "true" + Name + SourceFile + TargetFile + TypeSave;
            }
            else
            {
                return "error";
            }

        }


    }
}
