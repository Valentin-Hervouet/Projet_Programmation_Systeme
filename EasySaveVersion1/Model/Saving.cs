using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using static EasySaveVersion1.Model.EditJSon;
using System.Diagnostics;

namespace EasySaveVersion1.Model
{
    class Saving
    {        
        public string Save(string name)
        {

            var _instance = Model.StateLog.GetInstance();
            Statelogsave save = _instance.OpenSaveStateJSON(name);
            return SaveJob(save);
                   
        }


        public string SaveAll()
        {
            var _instance = Model.StateLog.GetInstance();
            var list = _instance.OpenStateJSON();

            if (list == null)
            {
                return "No save to save, create one with createsave";
            }
            else
            {
                string output = "";
                foreach (var item in list)
                {
                    output += item.Name + "\n";
                }
                return output;
            }
        }

        private string SaveJob(Statelogsave save)
        {
            if (save != null)
            {
                CopyFilesRecursively(save.SourceFilePath, save.TargetFilePath);

                return 
                    save.Name + "\n" + 
                    save.SourceFilePath +"\n" + 
                    save.TargetFilePath + "\n" + 
                    save.State + "\n" + 
                    save.TypeOfSave + "\n" +
                    save.TotalFilesToCopy + "\n" +
                    save.TotalFilesSize + "\n" +
                    save.NbFilesLeftToDo + "\n" +
                    save.Progression;
            }
            return "No save name -->\"" + save.Name + "\" List saves with \"listsave\" or create one with \"createsave\"";   
            
        }

        private static void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            //Now Create all of the directories
            if (Directory.Exists(sourcePath))
            {
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }
            }


                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

    }
}
