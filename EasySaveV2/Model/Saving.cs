using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;
using System.Xml.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Diagnostics;

namespace EasySaveV2.Model
{
    class Saving : EditJSon
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
                return "No save to save, create one with \"createsave\"";
            }
            else
            {
                string output = "";
                foreach (var item in list)
                {
                    output += Save(item.Name);
                }
                return output;
            }
        }

        private string SaveJob(Statelogsave save)
        {
            if (save != null)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                CopyFilesRecursively(save.SourceFilePath, save.TargetFilePath);
                watch.Stop();

                string watche = watch.Elapsed.ToString();

                return putstateindailylog(save, watche, GetDirectorySize(save.SourceFilePath));
            }
            return "No save name List saves with \"listsave\" or create one with \"createsave\"";

        }

        public long GetDirectorySize(string p)
        {
            if (File.Exists(p))
            {
                FileInfo info = new FileInfo(p);
                return info.Length;
            }
            else
            {
                string[] a = Directory.GetFiles(p, "*.*");

                long b = 0;
                foreach (string name in a)
                {
                    FileInfo info = new FileInfo(name);
                    b += info.Length;
                }
                return b;
            }
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

            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, targetPath + Path.GetFileName(sourcePath));
                return;
            }

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

    }
}
