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
	/// Interaction logic for FiszkiWindow.xaml
	/// </summary>
	public partial class FiszkiWindow : Window
	{
		WcfService.Slowka slowko = new WcfService.Slowka();
		public FiszkiWindow(string jezyk, string poziom)
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
					slowko = await client.LosujSlowkoDoFiszkiAsync(
						lblJezyk.Content.ToString(),
						lblPoziom.Content.ToString(),
						cmBxWybranaKategoria.SelectedItem.ToString(),
						Models.Token.NumerToken);
				}
				if (slowko.Tlumaczenie == null)
				{
					MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
					tbxSlowko.Text = null;
					tbxTlumaczenie.Text = null;
					return;
				}
				tbxSlowko.DataContext = slowko;
			}
			catch
			{
				MessageBox.Show(this, "Błąd połączenia z serwerem!", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
			}
		}

		private void btnTlumacz_Click(object sender, RoutedEventArgs e)
		{
			if (cmBxWybranaKategoria.SelectedItem == null)
			{
				MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
				Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			}
			else
			{
				Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
				tbxTlumaczenie.Text = slowko.Slowko;
			}
		}

		private void btnKolejneSlowko_Click(object sender, RoutedEventArgs e)
		{
			if (cmBxWybranaKategoria.SelectedItem == null)
			{
				MessageBox.Show("Nie wybrano żadnej kategorii!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
				Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			}
			else
			{
				tbxTlumaczenie.Text = null;
				Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
				PobierzSlowko();
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
