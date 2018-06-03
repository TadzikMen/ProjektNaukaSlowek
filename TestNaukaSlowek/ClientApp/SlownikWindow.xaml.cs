using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ClientApp
{
	/// <summary>
	/// Interaction logic for SlownikWindow.xaml
	/// </summary>
	public partial class SlownikWindow : Window
	{
		WyborWszystkichSlowekWindow wyborWszystkichSlowekWindow;
		List<WcfService.Slowka> listaDoFiltrowania;
		bool czyFiltrowacKategorie = false;

		public SlownikWindow()
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			InitializeComponent();
			ZaladujDaneDoFiltrowania();
		}

		private async void ZaladujDaneDoFiltrowania()
		{
			listaDoFiltrowania = new List<WcfService.Slowka>();
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					listaDoFiltrowania = await client.PrzekazDaneDoFiltrowaniaAsync(Models.Token.NumerToken);
				}

				foreach (var item in listaDoFiltrowania.Select(p=>p.Jezyk).Distinct().ToList())
					cmBxJezyk.Items.Add(item);

				foreach (var item in listaDoFiltrowania.Select(p=>p.Kategoria).Distinct().ToList())
					cmBxKategoria.Items.Add(item);

				foreach (var item in listaDoFiltrowania.Select(p=>p.Poziom).Distinct().ToList())
					cmBxPoziom.Items.Add(item);
			}
			catch (Exception)
			{
				MessageBox.Show($"Błąd pobierania danych do filtrowania słownika!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void SzukajTlumaczenieSlowa()
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			//WyczyscDaneFiltra();
			List<WcfService.Slowka> slowka = new List<WcfService.Slowka>();

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					slowka = await client.WyszukajTlumaczenieSlowkaAsync(tbxSlowko.Text, Models.Token.NumerToken);
				}
				dgSlownik.ItemsSource = slowka;
				dgtcKategoria.Visibility = Visibility.Hidden;
				dgtcPoziom.Visibility = Visibility.Hidden;
			}
			catch
			{
				MessageBox.Show("Błąd pobierania słówek z bazy danych!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void FiltrujDane()
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			List<WcfService.Slowka> listaSlowek = new List<WcfService.Slowka>();
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					listaSlowek = await client.FiltrujPrzezParametryAsync(
						cmBxJezyk.SelectedItem.ToString(),
						cmBxPoziom.SelectedItem.ToString(),
						cmBxKategoria.SelectedItem.ToString(),
						Models.Token.NumerToken);
				}
				dgSlownik.ItemsSource = listaSlowek;
				dgtcKategoria.Visibility = Visibility.Visible;
				dgtcPoziom.Visibility = Visibility.Visible;
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd pobierania słówek z bazy danych!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void btnSzukaj_Click(object sender, RoutedEventArgs e) => SzukajTlumaczenieSlowa();

		private void btnPokazWszystko_Click(object sender, RoutedEventArgs e)
		{
			//WyczyscDaneFiltra();
			wyborWszystkichSlowekWindow = new WyborWszystkichSlowekWindow(this);
			wyborWszystkichSlowekWindow.ShowDialog();
		}

		private void cmBxJezyk_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
		}

		private void btnWroc_Click_1(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
			rnw.Show();
			this.Close();
		}

		private void WyczyscDaneFiltra()
		{
			czyFiltrowacKategorie = false;
			cmBxJezyk.SelectedIndex = -1;
			cmBxKategoria.SelectedIndex = -1;
			cmBxPoziom.SelectedIndex = -1;
		}

		private void btnFiltruj_Click_1(object sender, RoutedEventArgs e)
		{
			FiltrujDane();
		}

		private async void PobierzKategorie()
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();

			try
			{
				cmBxKategoria.Items.Clear();
				List<WcfService.Slowka> kategorie = new List<WcfService.Slowka>();
				using (var client = new WcfService.Service1Client())
				{
					kategorie = await client.FiltrujKategorieDoSlownikaAsync(cmBxPoziom.SelectedItem.ToString(), Models.Token.NumerToken);
				}
				foreach (var item in kategorie)
					cmBxKategoria.Items.Add(item.Kategoria);
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd pobierania słówek z bazy danych!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void cmBxPoziom_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			PobierzKategorie();
		}
	}
}
