using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for Tlumaczenie.xaml
    /// </summary>
    public partial class Tlumaczenie : Window
	{ 

        List<WcfService.Slowka> slowka = new List<WcfService.Slowka>();
        string Slowko;
        int NumerWTabeliDanegoSlowka;
        bool Poprawnosc = true;
        bool WielkoscLiter = false;
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

        private void SprawdzWielkoscLiter()
        {
           if( lblJezyk.Content.ToString()== "NIEMIECKI " || lblJezyk.Content.ToString() == "HISZPANSKI ")
            {
                WielkoscLiter = true;
            }
        }
		
        private async void PobierzSlowko()
        {
            slowka.Clear();
            try
            {
                using (var client = new WcfService.Service1Client())
                {
                    tbxTlumaczenieUzytkownika.Text = "Tutaj wpisz tłumaczenie";
                    slowka = await client.FiltrujPrzezParametryAsync(
                        lblJezyk.Content.ToString(),
                        lblPoziom.Content.ToString(),
                        cmBxWybranaKategoria.SelectedItem.ToString(),
                        Models.Token.NumerToken);
                    SprawdzWielkoscLiter();

                    LosujSlowko();
                }
                BrakSlowek();


            }
            catch
            {
                MessageBox.Show(this, "Błąd połączenia z serwerem!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BrakSlowek()
        {
            if (slowka.Count == 0)
            {
                MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
                tbxSlowko.Text = null;
                tbxTlumaczenie.Text = null;
            }
        }

        private void btnSprawdz_Click(object sender, RoutedEventArgs e)
        {

            if (cmBxWybranaKategoria.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (tbxTlumaczenieUzytkownika.Text.ToLower() == Slowko && WielkoscLiter == false)
            {
                tbxTlumaczenie.Foreground = Brushes.Green;
                tbxTlumaczenie.Text = "Dobrze przetłumaczyłeś słówko";
                slowka.RemoveAt(NumerWTabeliDanegoSlowka);
                Poprawnosc = true;
            }
            else if (tbxTlumaczenieUzytkownika.Text == Slowko && WielkoscLiter == true)
            {
                tbxTlumaczenie.Foreground = Brushes.Green;
                tbxTlumaczenie.Text = "Dobrze przetłumaczyłeś słówko";
                slowka.RemoveAt(NumerWTabeliDanegoSlowka);
                Poprawnosc = true;
            }
            else
            {
                tbxTlumaczenie.Foreground = Brushes.Red;
               
                if (Poprawnosc == true)
                {
                    tbxTlumaczenie.Text = "Źle przetłumaczyłeś słówko";
                    Poprawnosc = false;
                }
                
                slowka.Add(slowka[NumerWTabeliDanegoSlowka]);
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
                    tbxTlumaczenie.Text = Slowko;                
            }
        }

        private void LosujSlowko()
        {
            BrakSlowek();
            tbxTlumaczenie.Text = "";
            if (slowka.Count != 0)
            {
                Random rand = new Random();
                NumerWTabeliDanegoSlowka = rand.Next(0, slowka.Count);
                tbxSlowko.Text = slowka[NumerWTabeliDanegoSlowka].Tlumaczenie.ToString();
                if (WielkoscLiter == false)
                {
                    Slowko = slowka[NumerWTabeliDanegoSlowka].Slowko.ToString().ToLower();
                }
                else
                {
                    Slowko = slowka[NumerWTabeliDanegoSlowka].Slowko.ToString();
                }
            }

        }

        private void btnKolejneSlowko_Click(object sender, RoutedEventArgs e)
        {
            tbxTlumaczenieUzytkownika.Text = "";
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
