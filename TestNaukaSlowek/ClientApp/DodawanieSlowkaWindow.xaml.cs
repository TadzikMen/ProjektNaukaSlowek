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
	/// Interaction logic for DodawanieSlowkaWindow.xaml
	/// </summary>
	public partial class DodawanieSlowkaWindow : Window
	{
		public DodawanieSlowkaWindow()
		{
			InitializeComponent();
			PrzekazDaneDoComboboxow();
		}

		private async void PrzekazDaneDoComboboxow()
		{
			try
			{
				List<WcfService.Slowka> listaDanych = new List<WcfService.Slowka>();
				using (var client = new WcfService.Service1Client())
				{
					listaDanych = await client.PrzekazJezykiKategoriePoziomyAsync();
				}
				foreach (var item in listaDanych.Select(p => p.Jezyk).Distinct().ToList())
					cmbxJezyk.Items.Add(item);

				foreach (var item in listaDanych.Select(p => p.Kategoria).Distinct().ToList())
					cmbxKategoria.Items.Add(item);

				foreach (var item in listaDanych.Select(p => p.Poziom).Distinct().ToList())
					cmbxPoziom.Items.Add(item);
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd przy połączeniu z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void DodajSlowko()
		{
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					await client.DodajSlowkoAsync(tbxSlowko.Text, tbxTlumaczenie.Text, cmbxJezyk.SelectedItem.ToString(), cmbxKategoria.SelectedItem.ToString(), cmbxPoziom.SelectedItem.ToString());
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd przy połączeniu z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private void btnOk_Click(object sender, RoutedEventArgs e)
		{
			if (tbxSlowko.Text != string.Empty && tbxTlumaczenie.Text != string.Empty && cmbxJezyk.SelectedIndex != -1 && cmbxKategoria.SelectedIndex != -1 && cmbxPoziom.SelectedIndex != -1)
			{
				DodajSlowko();
				this.Close();
			}
			else
			{
				MessageBox.Show("Nie wprowadzono wymaganych wartości!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Warning);
			}

		}
	}
}
