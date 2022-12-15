using EasySaveV2.Model.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace EasySaveV2.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        private string tbNameSave;
        private string tbName;
        private string tbSource;
        private string tbDest;
        private string tbType;
        private string name;
        private string source;
        private string type;
        private string nameSave;
        private string message;
        private string tbMessage;

        public string TBNameSave
        {
            set
            {
                tbNameSave = value;
            }
            get
            {
                return tbNameSave;
            }
        }
        public string TBName 
        {
            set
            {
                tbName = value;
                OnPropertyChanged("TBName");
            }
            get
            {
                return tbName;
            }
        }
        public string TBSource 
        {
            set
            {
                tbSource = value;
                OnPropertyChanged("TBSource");
            }
            get
            {
                return tbSource;
            }
        }
        public string TBDest 
        {
            set
            {
                tbDest = value;
                OnPropertyChanged("TBDest");
            }
            get
            {
                return tbDest;
            }
        }
        public string TBType 
        {
            set
            {
                tbType = value;
                OnPropertyChanged("TBType");
            }
            get
            {
                return tbType;
            }
            }

        public static uiCreateSave uiCreateSave
        {
            get
            {
                return new uiCreateSave();
            }
            set
            {
            }
        }
        public static uiSave uiSave
        {
            get
            {
                return new uiSave();
            }
            set
            {
            }
        }
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
            }
        public string Source 
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                OnPropertyChanged("Source");
            }
        }
        public string dest 
        {
            get
            {
                return dest;
            }
            set
            {
                dest = value;
                OnPropertyChanged("dest");
            }
        }

        public string Type 
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                OnPropertyChanged("type");
            }
            }
        public string NameSave 
        {
            get
            {
                return nameSave;
            }
            set
            {
                nameSave =value;
                OnPropertyChanged("nameSave");
            }
        }
        public string Message 
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                OnPropertyChanged("Message");
            }
        }
        public string TBmessage 
        {
            get
            {
                return tbMessage;
            }
            set
            {
                tbMessage = value;
                OnPropertyChanged("TBMessage");
            }
        }


        #region methods
        //MainWindow

        private void ShowCreate()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Show();
        }
        private void ShowSave()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiSave.Show();
        }
        private void Listsave()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            Model.StateLog logstate = Model.StateLog.GetInstance();
            Message = logstate.ListSave();
        }
        private void DailyLog()
        {
            Model.DailyLog logdaily = Model.DailyLog.GetInstance();
            Message = logdaily.ReadJSON();
        }
        private void StateLog()
        {
            Model.StateLog logstate = Model.StateLog.GetInstance();
            Message = logstate.ReadJSON();
        }
        private void DailyLogXML()
        {
            Model.DailyLog logdailyxml = Model.DailyLog.GetInstance();
            logdailyxml.ConvertJsontoXML();
            Message = logdailyxml.ReadXML();
        }
        private void StateLogXML()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            Model.StateLog logstatexml = Model.StateLog.GetInstance();
            logstatexml.ConvertJsontoXML();
            Message = logstatexml.ReadXML();
        }
        private void HelpMessage()
        {
            // Code à exécuter lorsque l'événement click est déclenché

            TBmessage = @"help -- show this help message
createsave -- Create a new save job (start guide to create save)
listsave -- List all save job created
save -- Start save job
saveall -- Save all jobs
logdaily -- Show daily log in JSON
logstate -- Show state log in JSON
logdailyxml -- Show daily log in XML
logstatexml -- Show state log in XML
clear -- Clear console
exit -- exit program";
            Message = TBmessage;
        }
        #endregion

        #region commands


        //MainWindow

        public ICommand ShowCreateCommand
        {
            get
            {
                return new RelayCommand(ShowCreate);
            }
        }

        public ICommand ShowSaveCommand
        {
            get
            {
                return new RelayCommand(ShowSave);
            }
        }

        public ICommand ListsaveCommand
        {
            get
            {
                return new RelayCommand(Listsave);
            }
        }

        public ICommand DailyLogCommand
        {
            get
            {
                return new RelayCommand(DailyLog);
            }
        }

        public ICommand StateLogCommand
        {
            get
            {
                return new RelayCommand(StateLog);
            }
        }

        public ICommand DailyLogXMLCommand
        {
            get
            {
                return new RelayCommand(DailyLogXML);
            }
        }

        public ICommand StateLogXMLCommand
        {
            get
            {
                return new RelayCommand(StateLogXML);
            }
        }

        public ICommand HelpMessageCommand
        {
            get
            {
                return new RelayCommand(HelpMessage);
            }
        }
        #endregion
    }
}
