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

namespace ProjectCdeBrani
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Brano> listaBrani;
        private List<Cd> listaCd;

        
        public MainWindow()
        {
            InitializeComponent();
            listaBrani = new List<Brano>();
            listaCd = new List<Cd>();


        }



        private void caricaBraniECd()
        {
            //TITOLO|AUTORE|DURATA|CD
            using(StreamReader sr = new StreamReader("brani.txt"))
            {

                string line;
                string titolo;
                string autore;
                int durata;
                string cd;

                do
                {

                    line = sr.ReadLine();
                    string[] lineSplittata = line.Split('|');
                    titolo = lineSplittata[0];
                    autore = lineSplittata[1];
                    durata = int.Parse(lineSplittata[2]);
                    cd = lineSplittata[3];

                    //Chiamo il costruttore di Brano


                } while (sr.EndOfStream);

            }



        }

    }
}
