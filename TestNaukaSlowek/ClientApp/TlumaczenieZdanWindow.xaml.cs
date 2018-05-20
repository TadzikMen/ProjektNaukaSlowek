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
    /// Interaction logic for TlumaczenieZdanWindow.xaml
    /// </summary>
    public partial class TlumaczenieZdanWindow : Window
    {
		List<WcfService.Slowka> listaZdan;
		int wylosowanyIndeks;
		string wylosowaneZdanie;

		public TlumaczenieZdanWindow(string jezyk)
        {
            InitializeComponent();
			lblJezyk.Content = jezyk;
			LosujZdanie();
        }

		private async void LosujZdanie()
		{
			try
			{
				listaZdan = new List<WcfService.Slowka>();
				Random rand = new Random();

				using (var client = new WcfService.Service1Client())
				{
					listaZdan = await client.PobierzZdaniaDoTlumaczeniaAsync(lblJezyk.Content.ToString(), Models.Token.NumerToken);
				}

				if (listaZdan.Count != 0)
				{
					wylosowanyIndeks = rand.Next(0, listaZdan.Count);
					wylosowaneZdanie = listaZdan[wylosowanyIndeks].Tlumaczenie;

					tbxWylosowaneZdanie.Text = wylosowaneZdanie;
				}
				else
					MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButton.OK, MessageBoxImage.Warning);
				
			}
			catch
			{
				MessageBox.Show("Błąd połączenia z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}

		}

		private bool SprawdzCzyPoprawneZdanie()
		{
			if (tbxWprowadzoneZdanie.Text == listaZdan[wylosowanyIndeks].Slowko)
				return true;

			else
				return false;
		}

		private void btnSprawdz_Click(object sender, RoutedEventArgs e)
		{
			if (SprawdzCzyPoprawneZdanie())
			{
				tbxTlumaczenie.Foreground = Brushes.Green;
				tbxTlumaczenie.Text = "Dobrze!";
			}
			else
			{
				tbxTlumaczenie.Foreground = Brushes.Red;
				tbxTlumaczenie.Text = "Źle :(";
			}
		}

		private void btnPokazTlumaczenie_Click(object sender, RoutedEventArgs e)
		{
			tbxTlumaczenie.Foreground = Brushes.Black;
			tbxTlumaczenie.Text = wylosowaneZdanie;
		}

		private void btnKolejneZdanie_Click(object sender, RoutedEventArgs e)
		{
			tbxTlumaczenie.Foreground = Brushes.Black;
			tbxTlumaczenie.Text = string.Empty;
			LosujZdanie();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rnw = new RozpocznijNaukeWindow();
			rnw.Show();
			this.Close();
		}
	}
}
