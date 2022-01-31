using System;
using System.Collections.Generic;
using System.IO;
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

namespace OdczytZPliku
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void BT_Wczytaj_Click(object sender, RoutedEventArgs e)
        {
            var file=WczytajPlik();
            if (file != null) PokazZawrtosc(file);
            else TB_ZawrtoscPLiku.Text = string.Empty;

        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Jeśli plik jest wczytany zwraca ścieżkę, jeśli nie jest wczytany zwraca null </returns>
        private string WczytajPlik()
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document"; // Default file name
            dialog.DefaultExt = ".txt"; // Default file extension
            dialog.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                // Open document
                string filename = dialog.FileName;
                TB_NazwaPliku.Foreground = Brushes.Black;
                TB_NazwaPliku.Text=filename;
                return filename;
            }
            else
            {
                TB_NazwaPliku.Foreground = Brushes.Red;
                TB_NazwaPliku.Text = "nie tak się robi, musisz wybrac plik";                
            }
            return null;
        }

        private void PokazZawrtosc(string pathFile)
        {
            StreamReader a = new StreamReader(pathFile);
            var tekst=a.ReadToEnd();
            TB_ZawrtoscPLiku.Text = tekst;

        }
    }
}
