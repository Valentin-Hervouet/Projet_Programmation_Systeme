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
        private string TBNameSave { set; get; }
        public uiSave()
        {
            InitializeComponent();
            Close.Click += new RoutedEventHandler(CloseSave);
            SaveOne.Click += new RoutedEventHandler(Saveone);
            SaveAll.Click += new RoutedEventHandler(Saveall);
        }
        public void CloseSave(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = MainWindow.CloseSave;
            del();
        }
        public void Saveone(object sender, RoutedEventArgs e)
        {
            TBNameSave = NameSave.Text;
            //Appel de la View Model en Save One en passant TBNameSave en argument
            Model.Saving save = new Model.Saving();
            MessageBox.Show(save.Save(TBNameSave));
            
        }
        public void Saveall(object sender, RoutedEventArgs e)
        {
            Model.Saving saveall = new Model.Saving();
            MessageBox.Show(saveall.SaveAll());
            //Appel de la View Model en Save All en passant TBNameSave en argument
        }
    }
}

