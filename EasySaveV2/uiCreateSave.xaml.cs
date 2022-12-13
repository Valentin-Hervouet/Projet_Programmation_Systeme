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
    /// Logique d'interaction pour uiCreateSave.xaml
    /// </summary>
    public partial class uiCreateSave : Window
    {
        public uiCreateSave()
        {
            InitializeComponent();
            Close.Click += new RoutedEventHandler(CloseCreate);
        }
        private void CloseCreate(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
        }
    }
}
