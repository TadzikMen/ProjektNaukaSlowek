using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for Tlumaczenie.xaml
    /// </summary>
    public partial class Tlumaczenie : Window
    {

        List<WcfService.Slowka> slowka = new List<WcfService.Slowka>();
        string Slowko;
        int Liczbaa;
        public Tlumaczenie(string jezyk, string poziom)
        {
            InitializeComponent();
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            lblJezyk.Content = jezyk;
            lblPoziom.Content = poziom;
            PrzekazWszystkieKategorie();
    
        }

        private async void PrzekazWszystkieKategorie()
        {
            List<WcfService.Slowka> kategorie = new List<WcfService.Slowka>();
            using (var client = new WcfService.Service1Client())
            {
                kategorie = await client.PobierzKategorieAsync(lblPoziom.Content.ToString(), Models.Token.NumerToken);
                foreach (var item in kategorie)
                {
                    cmBxWybranaKategoria.Items.Add(item.Kategoria);
                }
            }
        }


     

        private async void PobierzSlowko()
        {
      
            try
            {
                using (var client = new WcfService.Service1Client())
                {

                    Border1.Visibility = Visibility.Visible;
                    tbxTlumaczenieUzytkownika.Text = "Tutaj wpisz tłumaczenie";
                    slowka = await client.FiltrujPrzezParametryAsync(
                        lblJezyk.Content.ToString(),
                        lblPoziom.Content.ToString(),
                        cmBxWybranaKategoria.SelectedItem.ToString(),
                        Models.Token.NumerToken);

                    LosujSlowko();
                }
                if (slowka.Count == 0)
                {
                    MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
                    tbxSlowko.Text = null;
                    tbxTlumaczenie.Text = null;
                    return;
                }
                
            }
            catch
            {
                MessageBox.Show(this, "Błąd połączenia z serwerem!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnSprawdz_Click(object sender, RoutedEventArgs e)
        {

            if (cmBxWybranaKategoria.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbxTlumaczenieUzytkownika.Text.ToLower() == Slowko)
            {
                tbxTlumaczenie.Foreground = Brushes.Green;
                tbxTlumaczenie.Text = "Dobrze przetłumaczyłeś słówko";
                slowka.RemoveAt(Liczbaa);
                var delay = Task.Delay(100).ContinueWith(_ =>
                {
                    btnKolejneSlowko_Click(sender, e);
                });
                
            }
            else
            {

                tbxTlumaczenie.Foreground = Brushes.Red;
                tbxTlumaczenie.Text = "Źle przetłumaczyłeś słówko";
            }
        }

        private void KlikEnter(object sender, KeyEventArgs e)
        {
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            if (e.Key == Key.Return)
            {
                btnSprawdz_Click(sender, e);
            }
        }

        private void btnTlumacz_Click(object sender, RoutedEventArgs e)
        {
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();

            if (cmBxWybranaKategoria.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                    tbxTlumaczenie.Text = Slowko ;
            }
        }

        private void LosujSlowko()
        {
            tbxTlumaczenie.Text = "";
            Random rand = new Random();
            Liczbaa = rand.Next(0, slowka.Count);
            tbxSlowko.Text = slowka[Liczbaa].Tlumaczenie.ToString();

            Slowko = slowka[Liczbaa].Slowko.ToString().ToLower();

        }

        private void btnKolejneSlowko_Click(object sender, RoutedEventArgs e)
        {
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            if (cmBxWybranaKategoria.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                tbxTlumaczenie.Foreground = Brushes.Black;
                tbxTlumaczenie.Text = null;
                LosujSlowko();
            }
        }

        private void cmBxWybranaKategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            tbxTlumaczenie.Text = string.Empty;
            PobierzSlowko();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
            rnw.Show();
            this.Close();
        }
    }
}
