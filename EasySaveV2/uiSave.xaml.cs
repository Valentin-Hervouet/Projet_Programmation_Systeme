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
    /// <summary>
    /// Logique d'interaction pour uiSave.xaml
    /// </summary>
    public partial class uiSave : Window
    {
        public uiSave()
        {
            InitializeComponent();
            Close.Click += new RoutedEventHandler(CloseSave);
        }
        private void CloseSave(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = MainWindow.CloseSave;
            del();
        }
    }
}
