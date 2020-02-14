using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace PracticaAsyncAwait
{
    public partial class MainWindow
    {
        private string _routeExplorerFolder;

        private List<string> _listaDirectories;
        public MainWindow()
        {
            _listaDirectories = new List<string>();
            InitializeComponent();

            ButtonSecuencial.Content = "Boton 1 Secuencial";
            ButtonTPS.Content = "Boton 2 TPS";

            #region ---> Eventos botones
            // Event ButtonSecuencial
            ButtonSecuencial.Click += (sender, args) =>
            {
                LectureFolder();
                //_listaDirectories.Add("hola");
                //_listaDirectories.Add("hola1");
                //_listaDirectories.Add("hola2");
                //_listaDirectories.Add("hola3");
                //_listaDirectories.Add("hola4");
                //_listaDirectories.Add("hola5");
                ListBoxDirectoriesButton1.ItemsSource = _listaDirectories;

                //ListBoxDirectoriesButton1.ItemsSource = _routeExplorerFolder;
            };
            // Event ButtonTPS
            ButtonTPS.Click += (sender, args) =>
            {

            };
            // Event lecture const textbox
            TextBoxExplorerFolder.TextChanged += (sender, args) =>
            {
                _routeExplorerFolder = TextBoxExplorerFolder.Text;
            };

            #endregion


        }

        public void LectureFolder()
        {
            foreach (var direcotries in Directory.GetDirectories(_routeExplorerFolder))
            {
                _listaDirectories.Add(direcotries);
            }       
        }
    }
}
