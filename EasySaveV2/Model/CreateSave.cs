using System;

namespace EasySaveV2.Model
{
    class CreateSave
    {
        private String Name;
        private String SourceFile;
        private String TargetFile;
        private String TypeSave;

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

            // Check if Source and Target file exist
            if (InputPath.CheckPathSourceFile(SourceFile) == "" && InputPath.CheckPathTargetFile(TargetFile) == "")
            {
                SetName(Name);
                SetSourceFile(SourceFile);
                SetTargetFile(TargetFile);
            }
            else
            {
                // return to user error if source file doesn't exist 
                return InputPath.CheckPathSourceFile(SourceFile) + InputPath.CheckPathTargetFile(TargetFile);
            }

            // check create save Type or return error to the user
            if (TypeSave == "COMPLET" || TypeSave == "DIFFERENTIAL")
            {
                SetTypeSave(TypeSave);
            }
            else
            {
                return "error wrong type of save (only COMPLET or DIFFERENTIAL)";
            }

            // Get instance from StateLog Class (Singleton DP)
            Model.StateLog stateLoginstance = Model.StateLog.GetInstance();
            // If everything is right add save to the statelog JSON file 
            return stateLoginstance.WriteSaveToJson(GetName(), GetSourceFile(), GetTargetFile(), GetTypeSave());

        }
    }
}
