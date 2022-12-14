using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using EasySaveV2.Model.Commands;
using EasySaveV2;
using System.Xml.Linq;
using System.Windows.Input;

namespace EasySaveV2.ViewModel
{
    public class ViewModel : ViewModelBase
    {
        private string tbNameSave;
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
        public string TBName { set; get; }
        public string TBSource { set; get; }
        public string TBDest { set; get; }
        public string TBType { set; get; }

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
        public string Name { get;  set; }
        public string Source { get;  set; }
        public string Dest { get;  set; }

        public string  Type { get; set; }
        public string NameSave { get;  set; }


        #region methodes

        private void ShowCreate() //i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Show();
        }
        private void ShowSave()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiSave.Show();
        }
        private void Listsave()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur ListSave!");
        }
        private void DailyLog()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur DailyLog!");
        }
        private void StateLog()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur StateLog!");
        }
        private void DailyLogXML()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur DailyLogXML!");
        }
        private void StateLogXML()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur StateLogXML!");
        }
        private void HelpMessage()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show(@"help -- show this help message
createsave -- Create a new save job (start guide to create save)
listsave -- List all save job created
save -- Start save job
saveall -- Save all jobs
logdaily -- Show daily log in JSON
logstate -- Show state log in JSON
logdailyxml -- Show daily log in XML
logstatexml -- Show state log in XML
clear -- Clear console
exit -- exit program");
        }
        public static void CloseCreate()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Hide();
        }
        public static void CloseSave()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiSave.Hide();
        }

        private void CloseCreateuiSave()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = ViewModel.CloseCreate;
            del();
        }
        public void Createsave()//i
        {
            TBName = Name.ToString();
            TBSource = Source.ToString();
            TBDest = Dest.ToString();
            TBType = Type.ToString();
            //Appel de la View Model en Create en passant les 4 strings en argument en argument
        }

        public void CloseSaveMain()//i
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = ViewModel.CloseSave;
            del();
        }
        public void Saveone()
        {
            TBNameSave = NameSave.ToString();
            //Appel de la View Model en Save One en passant TBNameSave en argument
        }
        public void Saveall()
        {
            //Appel de la View Model en Save All en passant TBNameSave en argument
        }
        #endregion

        #region commands
        public ICommand CreateSaveCommand
        {
            get
            {
                return new RelayCommand(Createsave);
            }
        }

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

        public ICommand CloseCreateuiSaveCommand
        {
            get
            {
                return new RelayCommand(CloseCreateuiSave);
            }
        }

        public ICommand CloseSaveMainCommand
        {
            get
            {
                return new RelayCommand(CloseSaveMain);
            }
        }

        public ICommand SaveoneCommand
        {
            get
            {
                return new RelayCommand(Saveone);
            }
        }

        public ICommand SaveallCommand
        {
            get
            {
                return new RelayCommand(Saveall);
            }
        }
        #endregion
    }
}
