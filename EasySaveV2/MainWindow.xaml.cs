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
        private static uiCreateSave uiCreateSave { get; set; }
        private static uiSave uiSave { get; set; }

        public MainWindow()
        {
            //Lancement de la Fenetre
            InitializeComponent();
            //Création d'une nouvelle instance de chaque fenêtre
            uiCreateSave = new uiCreateSave();
            uiSave = new uiSave();


            //Definitions des actions de chaques boutons
            CreateSave.Click += new RoutedEventHandler(ShowCreate);
            Save.Click += new RoutedEventHandler(ShowSave);
            ListSave.Click += new RoutedEventHandler(Listsave);
            Daily.Click += new RoutedEventHandler(DailyLog);
            State.Click += new RoutedEventHandler(StateLog);
            Dailyxml.Click += new RoutedEventHandler(DailyLogXML);
            Statexml.Click += new RoutedEventHandler(StateLogXML);
            Help.Click += new RoutedEventHandler(HelpMessage);
        }
        private void ShowCreate(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiCreateSave.Show();
        }
        private void ShowSave(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            uiSave.Show();
        }
        private void Listsave(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur ListSave!");
        }
        private void DailyLog(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur DailyLog!");
        }
        private void StateLog(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur StateLog!");
        }
        private void DailyLogXML(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur DailyLogXML!");
        }
        private void StateLogXML(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur StateLogXML!");
        }
        private void HelpMessage(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            MessageBox.Show("Vous avez cliqué sur Help!");
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
    }
}

