using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasySaveV2
{
    
    public partial class uiCreateSave : Window
    {
        // Rentre dans le VM
        private string TBName { set; get; }
        private string TBSource { set; get; }
        private string TBDest { set; get; }
        private string TBType { set; get; }
        public uiCreateSave()
        {
            InitializeComponent();
            //Disparait
            Close.Click += new RoutedEventHandler(CloseCreate);
            Create.Click += new RoutedEventHandler(Createsave);
        }
        private void CloseCreate(object sender, RoutedEventArgs e)// Rentre dans le VM
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = MainWindow.CloseCreate;
            del();
        }
        public void Createsave(object sender, RoutedEventArgs e)// Rentre dans le VM
        {
            TBName = Name.ToString();
            TBSource = Source.ToString();
            TBDest = Dest.ToString();
            TBType = Type.ToString();
            //Appel de la View Model en Create en passant les 4 strings en argument en argument
        }
    }
}
