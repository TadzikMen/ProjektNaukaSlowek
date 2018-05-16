﻿using System;
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
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            InitializeComponent();
			ZaladujDaneDoFiltrowania();
        }

		private async void ZaladujDaneDoFiltrowania()
		{
			List<WcfService.Slowka> listaDoFiltrowania = new List<WcfService.Slowka>(); 
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					listaDoFiltrowania = await client.PrzekazDaneDoFiltrowaniaAsync(Models.Token.NumerToken);
				}

				var listaJezykow = listaDoFiltrowania.Where(x => x.Jezyk != null).ToList();
				var listaKategorii = listaDoFiltrowania.Where(x => x.Kategoria != null).ToList();
				var listaPoziomow = listaDoFiltrowania.Where(x => x.Poziom != null).ToList();

				foreach (var item in listaJezykow)
					cmBxJezyk.Items.Add(item.Jezyk);

				foreach (var item in listaKategorii)
					cmBxKategoria.Items.Add(item.Kategoria);

				foreach (var item in listaPoziomow)
					cmBxPoziom.Items.Add(item.Poziom);
			}
			catch (Exception)
			{
				MessageBox.Show($"Błąd pobierania danych do filtrowania słownika!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void SzukajTlumaczenieSlowa()
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
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
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
        }

		private void btnWroc_Click_1(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
			rnw.Show();
			this.Close();
		}
	}
}
