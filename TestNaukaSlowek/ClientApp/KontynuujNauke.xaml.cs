using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for KontynuujNauke.xaml
    /// </summary>
    public partial class KontynuujNauke : Window
    {
        public KontynuujNauke()
        {
            InitializeComponent();
            PobierzFormyNauki();
            Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
        }
        private string PrzekazWybranyPoziom => cmBxWybierzPoziom.SelectedValue.ToString();

        private async void PobierzFormyNauki()
        {
            Models.KontrolerWyboruNauki wyborFormy = new Models.KontrolerWyboruNauki();

            try
            {
                using (var client = new WcfService.Service1Client())
                {
                    wyborFormy.ListaWyboruNauki = await client.PobierzFormyNaukiAsync(Models.Token.NumerToken);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    messageBoxText: $"Błąd pobierania danych z bazy danych!\nOpis błędu:\n{ex.ToString()}",
                    caption: "Błąd",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Error);
            }

            
            foreach (var item in wyborFormy.ListaWyboruNauki.Select(x => x.Jezyk).Distinct().ToList())
                cmBxWybierzJezyk.Items.Add(item);

            foreach (var item in wyborFormy.ListaWyboruNauki.Select(x => x.Poziom).Distinct().ToList())
                cmBxWybierzPoziom.Items.Add(item);

        }

        private void PrzelaczOknoNauki()
        {
            Models.RozpoczynanieNauki rozpoczynanie;

            
                rozpoczynanie = new Models.RozpoczynanieNauki();
               
                
                        rozpoczynanie.Jezyk = cmBxWybierzJezyk.SelectedItem.ToString();
                        rozpoczynanie.Poziom = cmBxWybierzPoziom.SelectedItem.ToString();
            
                            Tlumaczenie fw = new Tlumaczenie(rozpoczynanie.Jezyk, rozpoczynanie.Poziom, false);
                            fw.Show();
                            this.Close();
                       
              

        }

        private void btnRozpocznij_Click(object sender, RoutedEventArgs e)
        {
            PrzelaczOknoNauki();
        }

        private void btnWroc_Click(object sender, RoutedEventArgs e)
        {
            AplikacjaWindow aw = new AplikacjaWindow();
            aw.Show();
            this.Close();
        }


        private void cmBxWybierzJezyk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
