using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Linq;

namespace EasySaveVersion1.Model
{
    class StateLog : EditJSon
    {
        private string testpath = "/tmp/hello.json";

        private static StateLog instance;
        private string NameSave;
        private string TimeDate;
        private string State;
        private string NumberFiles;
        private string Size;
        private string SourceFile;
        private string TargetFile;
        private string DefaultPath;
        private const string Path = "C:\\Users\\fclea\\Documents\\CESI\\Projet 2\\Code\\Projet_Programmation_Systeme\\EasySaveVersion1\\StateLog.json";
        //This is a temporary file that I use to work, we will change it when we will finish all
        public delegate string DelgGet();

        //Singleton set up
        private StateLog()
        {

        }


        public static StateLog GetInstance()
        {
            if (instance == null)
            {

                instance = new StateLog();
            }
            return instance;
        }

        //Gets
        public string GetDefaultPath()
        {
            return DefaultPath;
        }
        public string GetName()
        {
            return NameSave;
        }
        public string GetTime()
        {
            return TimeDate;
        }
        public string GetState()
        {
            return State;
        }
        public string GetNumberFiles()
        {
            return NumberFiles;
        }
        public string GetSize()
        {
            return Size;
        }
        public string GetSource()
        {
            return SourceFile;
        }
        public string GetTarget()
        {
            return TargetFile;
        }

        //Sets
        public void SetDefaultPath(string input)
        {
            DefaultPath = input;
        }
        public void SetName(string input)
        {
            NameSave = input;
        }
        public void SetTime(string input)
        {
            TimeDate = input;
        }
        public void SetState(string input)
        {
            State = input;
        }
        public void SetNumberFiles(string input)
        {
            NumberFiles = input;
        }
        public void SetSize(string input)
        {
            Size = input;
        }
        public void SetSource(string input)
        {
            SourceFile = input;
        }
        public void SetTarget(string input)
        {
            TargetFile = input;
        }




        //Methods
        public string GetAllAttributes()
        {
            DelgGet delgcast = GetDefaultPath;
            delgcast += GetName;
            delgcast += GetTime;
            delgcast += GetState;
            delgcast += GetNumberFiles;
            delgcast += GetSize;
            delgcast += GetTarget;
            delgcast += GetSource;

            return delgcast();
        }
        public void SetAllAttributes(string Name, string Time, string State, string Number, string Size, string Source, string Target)
        {
            this.NameSave = Name;
            this.TimeDate = Time;
            this.State = State;
            this.NumberFiles = Number;
            this.Size = Size;
            this.SourceFile = Source;
            this.TargetFile = Target;
        }
        /*
        public void WriteJSON()
        {
            try
            {
                StreamWriter write = new StreamWriter(Path);

                // Write all the infos in the daily log text in a JSON format
                write.WriteLine("{");
                write.WriteLine("   'Name': " + this.NameSave);
                write.WriteLine("   'Number': " + this.NumberFiles);
                write.WriteLine("   'State': " + this.State);
                write.WriteLine("   'File Source': " + this.SourceFile);
                write.WriteLine("   'FileTarget': " + this.TargetFile);
                write.WriteLine("   'FileSize': " + this.Size);
                write.WriteLine("   'FileDate': " + this.TimeDate);
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
        */


        public string ReadStateLog()
        {
            Boolean succes = true;
            string Line;

            if (succes == true)
            {
                try
                {
                    StreamReader sr = new StreamReader("C:\\Users\\lolah\\Projet_Programmation_Systeme\\EasySaveVersion1\\StateLog.json");
                    Line = sr.ReadLine();
                    while (Line != null)
                    {
                        Console.WriteLine(Line);
                        Line = sr.ReadLine();
                    }
                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
                return "true";
            }
            else
            {
                return "error";
            }

        }

        /*
        public string WriteSaveToJson(string Name, string SourceFile, string TargetFile, string TypeSave)
        {
            // 2 time sourceFile here for the same variable !!!

            return SimpleWrite(ReadStateLogJSON(SourceFile), SourceFile);
        }
        */  

    }



}

