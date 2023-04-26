using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Threading;
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
        private string labelprogress;
        private int barrechargement;

        private string TBNameSave { set; get; }

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

        public uiSave()
        {
            InitializeComponent();
            //SaveOne.Click += new RoutedEventHandler(Saveone);
            //SaveAll.Click += new RoutedEventHandler(Saveall);
        }
        public void CloseSave(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = MainWindow.CloseSave;
            del();
        }
        public void Saveone()
        {
            TBNameSave = NameSave.Text;
            long maxFileSize = 10 * 1024 * 1024; // 10 megabytes
            //Appel de la View Model en Save One en passant TBNameSave en argument
            Model.Saving save = new Model.Saving();
            long Size = save.Size(TBNameSave);
            if (Size > maxFileSize)
            {
                MessageBox.Show("Your file size is too large. You can't exceed 10Mb");
            }
            else
            {
                MessageBox.Show(save.Save(TBNameSave));
                

            }
            
            
        }
        public void Saveall()
        {
            Model.Saving saveall = new Model.Saving();
            MessageBox.Show(saveall.SaveAll());
            //Appel de la View Model en Save All en passant TBNameSave en argument
        }


        


    }
}

