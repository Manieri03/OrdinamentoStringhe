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

namespace OrdinamentoStringhe
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
        int c = 0;
        string[] stringa = new string[5];

        private void btninserisci_Click(object sender, RoutedEventArgs e)
        {
            c++;
            stringa[c - 1] = txtstringa.Text;
            if (c == 5)
            {
                btninserisci.IsEnabled = false;
                btnstampa.IsEnabled = true;
            }
            txtstringa.Clear();
        }

        private void btnstampa_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lblelenco.Content += $"-{i + 1}° messaggio:  {stringa[i]} \n";
            }
            btnordina.IsEnabled = true;
            
        }

        private void btnordina_Click(object sender, RoutedEventArgs e)
        {

            btnpubblica.IsEnabled = true;
            Array.Sort(stringa);
            for (int j = 0; j< 5; j++)
            {
                lblordinato.Content=$"-{j + 1}° messaggio:  {stringa[j]} \n";
            }
        }

        private void btnpubblica_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("stringhe.txt", false, Encoding.UTF8))
            {
                Array.Sort(stringa);
                for (int i = 0; i < 5; i++)
                {
                    sw.WriteLine($"-{i + 1}° messaggio: {stringa[i]} \n");
                }
            }

        }
    }
}
