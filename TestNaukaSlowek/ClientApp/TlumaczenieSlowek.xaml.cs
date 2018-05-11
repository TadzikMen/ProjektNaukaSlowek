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
    /// Interaction logic for Slownik.xaml
    /// </summary>
    public partial class Slownik : Window
    {
        WcfService.Slowka slowko = new WcfService.Slowka();

        public Slownik(string jezyk, string poziom)
        {

            InitializeComponent();

            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();

            lblJezyk.Content = jezyk;
            lblPoziom.Content = poziom;

            PrzekazWszystkieKategorie();
        }

        private async void PobierzSlowko()
        {
            using (var client = new WcfService.Service1Client())
            {
                slowko = await client.LosujSlowkoDoFiszkiAsync(
                    lblJezyk.Content.ToString(),
                    lblPoziom.Content.ToString(),
                    cmBxWybranaKategoria.SelectedItem.ToString(),
                    Models.Token.NumerToken);
            }
            if (slowko.Tlumaczenie == null)
            {
                MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
                LabTlumaczenie = null;
                TxbTlumaczenie.Text = null;
                return;
            }
            LabTlumaczenie.Content = slowko.Tlumaczenie;
        }

        private void cmBxWybranaKategoria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TxbTlumaczenie.Text = null;
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            PobierzSlowko();
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
    }
}
