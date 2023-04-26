using EasySaveV2.Model;
using EasySaveV2.Model.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace EasySaveV2.ViewModel
{
    
    public class ViewModel : ViewModelBase
    {
        private string LangueLangue { set; get; }
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
        private string labelprogress;
        private int barrechargement; //Mis en int pour le moment, mais il s'agit de la barre de progressement, le type sera changé plus tard pour un type mieux adapté
        private ManualResetEvent _event = new ManualResetEvent(true);
        private readonly DoWorkEventArgs e ;
        private Saving save;

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


        //Mis en int pour le moment, mais il s'agit de la barre de progressement, le type sera changé plus tard pour un type mieux adapté
        public int Barrechargement
        {
            get
            {
                return barrechargement;
            }
            set
            {
                barrechargement = value;
            }
        }

        public string Labelprogress
        {
            get
            {
                return labelprogress;
            }
            set
            {
                labelprogress = value;
            }
        }



        public static BackgroundWorker worker
        {
            get
            {
                return new BackgroundWorker();
            }
            set
            {
            }
        }

        #region methods
        //MainWindow

        private void ShowCreate()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Show();
        }

        //The following two methods are there to call the methods in the uiSave.xaml.cs file
        private void Save()
        {
            object sender = new object();
            DoWorkEventArgs e = new DoWorkEventArgs(sender);
            worker_DoWork(sender, e);
        }

        private void SaveAll()
        {
            uiSave.Saveall();
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
        public static void CloseCreate()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Hide();
        }
        public static void CloseSave()
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiSave.Hide();
        }
        public void EN()
        {
            LangueLangue = "en";
        }
        public void FR()
        {
            LangueLangue = "fr";
        }


        //TO be put in commands
        public void Pause_work()
        {
            worker_Pause();
        }

        public void Stop_work()
        {
            worker_Stop();
        }


        public void Resume_work()
        {
            worker_resume();
        }

        public void Start_work()
        {
            worker_Start();
        }

        //Now, this part is for putting the progression bar and the play/stop/pause/resume buttons

        //Stop the progression
        private void worker_Stop()
        {
            if (worker.WorkerSupportsCancellation == true)
            {
                _event.Reset();
                // Cancel the asynchronous operation.
                worker.CancelAsync();
            }
        }


        //pause 
        //Thread pause = new Thread(new ThreadStart(worker_DoWork));

        private void worker_Pause()
        {
            _event.Reset();

        }

        //Resume 
        private void worker_resume()
        {
            _event.Set();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            uiSave.Saveone();
            while (true)
            {
                _event.WaitOne(Timeout.Infinite);
                int i = 1;
                while (Convert.ToBoolean(save.Save(TBNameSave)))
                {
                    worker.ReportProgress(i);

                    Thread.Sleep(2000);

                    i++;
                }
            }
        }

        //Progression
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Initialization of the progression bar
            Barrechargement = e.ProgressPercentage;

            // Show the progression on a label
            Labelprogress = Barrechargement.ToString() + "%";



        }

        // Start the progression bar by creating a BackgroundWorker object
        //BackgroundWorker :
        private void worker_Start()
        {
            //création, initialisation et mise à jour de l'objet BackgroundWorker
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            _event.Set();
            worker.RunWorkerAsync();
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
        //The two command under this comment are for the uiSave.xaml file 
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(Save);
            }
        }

        public ICommand SaveAllCommand
        {
            get
            {
                return new RelayCommand(SaveAll);
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

        public ICommand CloseCreateCommand
        {
            get
            {
                return new RelayCommand(CloseCreate);
            }
        }


        public ICommand CloseSaveCommand
        {
            get
            {
                return new RelayCommand(CloseSave);
            }
        }

        public ICommand LangueEN
        {
            get
            {
                return new RelayCommand(EN);
            }
        }
        public ICommand LangueFR
        {
            get
            {
                return new RelayCommand(FR);
            }
        }

        #endregion
    }
}
