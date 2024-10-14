using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EsercitazioneCD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Brano brano;
        private CD cd;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void VisualizzaBrano_Click(object sender, RoutedEventArgs e)
        {
            string titolo = TitoloTextBox.Text;
            string autore = AutoreTextBox.Text;

            if (int.TryParse(DurataTextBox.Text, out int durata))
            {
                brano = new Brano(titolo, autore, durata);
                BranoInfo.Text = brano.ToString();
            }
            else
            {
                MessageBox.Show("Inserire una durata valida.");
            }
        }

        private void CreaCD_Click(object sender, RoutedEventArgs e)
        {
            string titoloCD = CDTitoloTextBox.Text;
            string autoreCD = CDAutoreTextBox.Text;

            cd = new CD(titoloCD, autoreCD);
            CDInfo.Text = $"CD creato: {cd.GetTitolo()} di {cd.GetAutore()}";
        }

        private void AggiungiBranoCD_Click(object sender, RoutedEventArgs e)
        {
            if (cd == null || brano == null)
            {
                MessageBox.Show("Devi creare un CD e visualizzare un brano prima.");
                return;
            }

            cd.AggiungiBrano(brano);
            CDBraniInfo.Text = cd.ToString();
        }

        private void VerificaBrevi_Click(object sender, RoutedEventArgs e)
        {
            if (cd == null)
            {
                MessageBox.Show("Devi prima creare un CD.");
                return;
            }

            if (int.TryParse(DurataLimiteTextBox.Text, out int durataLimite))
            {
                string risultati = "Brani brevi:\n";
                bool found = false;

                foreach (var b in cd.brani) // Assicurati di avere accesso alla lista brani
                {
                    if (b.ShortSong(durataLimite))
                    {
                        risultati += $"{b.GetTitolo()} di {b.GetAutore()} - {b.GetDurata()} minuti\n";
                        found = true;
                    }
                }

                if (!found)
                {
                    risultati = "Nessun brano breve trovato.";
                }

                ShortSongResults.Text = risultati;
            }
            else
            {
                MessageBox.Show("Inserire una durata limite valida.");
            }
        }
    }
}