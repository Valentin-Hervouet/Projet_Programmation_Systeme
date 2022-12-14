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
        private string TBName { set; get; }
        private string TBSource { set; get; }
        private string TBDest { set; get; }
        private string TBType { set; get; }
        public uiCreateSave()
        {
            InitializeComponent();
            Close.Click += new RoutedEventHandler(CloseCreate);
            Create.Click += new RoutedEventHandler(Createsave);
        }
        private void CloseCreate(object sender, RoutedEventArgs e)
        {
            // Code à exécuter lorsque l'événement click est déclenché
            //MainWindow.CloseCreate();
            MyDel del = MainWindow.CloseCreate;
            del();
        }
        public void Createsave(object sender, RoutedEventArgs e)
        {
            TBName = Name.Text; // .ToString();
            TBSource = Source.Text;
            TBDest = Dest.Text;
            TBType = Type.Text;
            //Appel de la View Model en Create en passant les 4 strings en argument en argument

            Model.CreateSave createsave = new Model.CreateSave();

            //MessageBox.Show(" name -->\"" + TBName + "\"  Source -->\"" + TBSource + "\"  Dest -->\"" + TBDest + "\"  Type -->\"" + TBType);

            MessageBox.Show(createsave.CreateSaveInLogFile(TBName, TBSource, TBDest, TBType));
            



        }
    }
}
