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
    /// Interaction logic for SlownikWindow.xaml
    /// </summary>
    public partial class SlownikWindow : Window
    {
		WyborWszystkichSlowekWindow wyborWszystkichSlowekWindow;

		public SlownikWindow()
        {
            InitializeComponent();
        }

		private async void SzukajTlumaczenieSlowa()
		{
			List<WcfService.Slowka> slowka = new List<WcfService.Slowka>();

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					slowka = await client.WyszukajTlumaczenieSlowkaAsync(tbxSlowko.Text, Models.Token.NumerToken);
				}
				dgSlownik.ItemsSource = slowka;
			}
			catch
			{
				MessageBox.Show("Błąd pobierania słówek z bazy danych!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void FiltrujDane()
		{

		}

		private void btnSzukaj_Click(object sender, RoutedEventArgs e) => SzukajTlumaczenieSlowa();


		private void btnFiltruj_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btnPokazWszystko_Click(object sender, RoutedEventArgs e)
		{
			wyborWszystkichSlowekWindow = new WyborWszystkichSlowekWindow(this);
			wyborWszystkichSlowekWindow.ShowDialog();
		}
	

        private void cmBxJezyk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

		private void btnWroc_Click_1(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
			rnw.Show();
			this.Close();
		}
	}
}
