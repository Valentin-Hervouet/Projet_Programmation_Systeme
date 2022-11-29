using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.IO;

namespace EasySaveVersion1.Model
{
    class DailyLog : EditJSon
    {
        #region attributes
        private String NameSave;
        private String TimeDate;
        private String SourceFile;
        private String TargetFile;
        private double Size;
        private int Duration;
        private DailyLog instance;
        private const String Path = "C:\\Users\\lolah\\Projet_Programmation_Systeme\\EasySaveVersion1\\DailyLog.txt";
        //This is a temporary file that I use to work, we will change it when we will finish all
        #endregion

        #region methods
        //Constructor
        private DailyLog()
        {

        }

        //Set
        public void set(String NameSave, String TimeDate, String SourceFile, String TargetFile, double Size, int Duration)
        {
            this.NameSave = NameSave;
            this.TimeDate = TimeDate;
            this.SourceFile = SourceFile;
            this.TargetFile = TargetFile;
            this.Size = Size;
            this.Duration = Duration;
        }

        //Get
        public String NameSaveGet()
        {
            return NameSave;
        }

        public String TimeDateGet()
        {
            return TimeDate;
        }

        public String SourceFileGet()
        {
            return SourceFile;
        }

        public String TargetFileGet()
        {
            return TargetFile;
        }

        public double SizeGet()
        {
            return Size;
        }

        public int DurationGet()
        {
            return Duration;
        }

        public DailyLog GetInstance()
        {
            if (instance == null)
            {
                instance = new DailyLog();
            }
            return instance;
        }


        public void WriteJSON()
        {
            try
            {
                StreamWriter write = new StreamWriter(Path);

                // Write all the infos in the daily log text in a JSON format
                write.WriteLine("{");
                write.WriteLine("   'Name': " + this.NameSave);
                write.WriteLine("   'File Source': " + this.SourceFile);
                write.WriteLine("   'FileTarget': " + this.TargetFile);
                write.WriteLine("   'destPath': ''");
                write.WriteLine("   'FileSize': " + this.Size);
                write.WriteLine("   'FileTransfertTime': " + this.Duration);
                write.WriteLine("   'time': " + this.TimeDate);
                write.WriteLine("}");
                //Close the file
                write.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("End method");
            }
           
        }



        public void ReadJSON()
        {
            try
            {
                StreamReader reader = new StreamReader(Path);
                // Read the lines in the text file
                String line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                //Close the file 
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("End Method");
            }
            
        }
        #endregion



        public Boolean ReadDailLog() {
            // Output
            // True or False

            return true;
        }

    }
}
