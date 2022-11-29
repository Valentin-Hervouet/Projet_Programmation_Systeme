using System;
using System.Collections.Generic;
using System.Text;

namespace EasySaveVersion1.Model
{
    class StateLog : EditJSon
    {
        private StateLog instance;
        private string NameSave;
        private string TimeDate;
        private string State;
        private int NumberFiles;
        private double Size;
        private string SourceFile;
        private string TargetFile;

        //Singleton set up
        private StateLog()
        {
            
        }
        public StateLog GetInstance()
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
        public int GetNumberFiles()
        {
            return NumberFiles;
        }
        public double GetSize()
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
        public void SetNumberFiles(int input)
        {
            NumberFiles = input;
        }
        public void SetSize(double input)
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
    }
}
