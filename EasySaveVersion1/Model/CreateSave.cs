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

        private string GetName()
        {
            return this.Name;
        }
        private void SetName(string Name)
        {
            this.Name = Name;
        }

        private string GetSourceFile()
        {
            return this.SourceFile;
        }
        private void SetSourceFile(string SourceFile)
        {
            this.SourceFile = SourceFile;
        }

        private string GetTargetFile()
        {
            return this.TargetFile;
        }
        private void SetTargetFile(string TargetFile)
        {
            this.TargetFile = TargetFile;
        }

        private string GetTypeSave()
        {
            return this.TypeSave;
        }
        private void SetTypeSave(string TypeSave)
        {
            this.TypeSave = TypeSave;
        }





        public string CreateSaveInLogFile(string Name, string SourceFile, string TargetFile, string TypeSave)
        {


            Model.CheckInput InputPath = new Model.CheckInput(); 

            if (InputPath.CheckPath(SourceFile) == "true")
            {
                SetName(Name);
                SetSourceFile(SourceFile);
                SetTargetFile(TargetFile);
            }
            else
            {
                return InputPath.CheckPath(SourceFile);
            }

            if (TypeSave == "complet" || TypeSave == "differential")
            {
                SetTypeSave(TypeSave);
            }
            else
            {
                return "error wrong type of save (only complet or differential)";
            }

            Model.StateLog stateLoginstance = Model.StateLog.GetInstance();

            if (stateLoginstance.NumberOfSave("/tmp/hello.json") >= 5){
                return "Already 5 saves";
            }
            else
            {
                return stateLoginstance.WriteSaveToJson(Name, SourceFile, TargetFile, TypeSave);
            }

            


            // call function to write save in statelog file
            // input --> (GetName(),GetSourceFile(),GetTargetFile(),GetTypeSave())
            //
            // output error message or sucess message


            Boolean succes = true;

            if (succes == true)
            {
                return "Savejob saved --> " + Name + " " + SourceFile + " " + TargetFile + " " + TypeSave;
            }
            else
            {
                return "error";
            }

        }




    }
}
