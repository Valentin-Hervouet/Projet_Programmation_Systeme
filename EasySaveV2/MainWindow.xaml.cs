using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EasySaveV2
{
    public delegate void MyDel();
    public partial class MainWindow : Window
    {
        //Rentre dans le VM
        private static uiCreateSave uiCreateSave { get; set; }
        private static uiSave uiSave { get; set; }

        public MainWindow()
        {
            //Lancement de la Fenetre
            InitializeComponent();
            //Création d'une nouvelle instance de chaque fenêtre
            //Rentre dans le VM
            uiCreateSave = new uiCreateSave();
            uiSave = new uiSave();


            //Definitions des actions de chaques boutons
            //Disparait
            //CreateSave.Click += new RoutedEventHandler(ShowCreate);
            //Save.Click += new RoutedEventHandler(ShowSave);
            //ListSave.Click += new RoutedEventHandler(Listsave);
            //Daily.Click += new RoutedEventHandler(DailyLog);
            //State.Click += new RoutedEventHandler(StateLog);
            //Dailyxml.Click += new RoutedEventHandler(DailyLogXML);
            //Statexml.Click += new RoutedEventHandler(StateLogXML);
            //Help.Click += new RoutedEventHandler(HelpMessage);
        }
//        private void ShowCreate(object sender, RoutedEventArgs e) // Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            uiCreateSave.Show();
//        }
//        private void ShowSave(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            uiSave.Show();
//        }
//        private void Listsave(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show("Vous avez cliqué sur ListSave!");
//        }
//        private void DailyLog(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show("Vous avez cliqué sur DailyLog!");
//        }
//        private void StateLog(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show("Vous avez cliqué sur StateLog!");
//        }
//        private void DailyLogXML(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show("Vous avez cliqué sur DailyLogXML!");
//        }
//        private void StateLogXML(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show("Vous avez cliqué sur StateLogXML!");
//        }
//        private void HelpMessage(object sender, RoutedEventArgs e)// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            MessageBox.Show(@"help -- show this help message
//createsave -- Create a new save job (start guide to create save)
//listsave -- List all save job created
//save -- Start save job
//saveall -- Save all jobs
//logdaily -- Show daily log in JSON
//logstate -- Show state log in JSON
//logdailyxml -- Show daily log in XML
//logstatexml -- Show state log in XML
//clear -- Clear console
//exit -- exit program");
//        }
//        public static void CloseCreate()// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            uiCreateSave.Hide();
//        }
//        public static void CloseSave()// Rentre dans le VM
//        {
//            // Code à exécuter lorsque l'événement click est déclenché
//            uiSave.Hide();
//        }
    }
}

