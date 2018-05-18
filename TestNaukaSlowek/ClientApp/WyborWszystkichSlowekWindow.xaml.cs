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
    /// Interaction logic for WyborWszystkichSlowekWindow.xaml
    /// </summary>
    public partial class WyborWszystkichSlowekWindow : Window
    {
		private SlownikWindow _slownikWindow;
        public WyborWszystkichSlowekWindow()
        {
            InitializeComponent();
			PobierzJezykiZSerwera();
        }

		public WyborWszystkichSlowekWindow(SlownikWindow slownikWindow) : this()
		{
			this._slownikWindow = slownikWindow;
		}

		private string WybranyJezyk => cmBxJezyk.SelectedItem.ToString();
		
		private async void PobierzJezykiZSerwera()
		{
			try
			{
				Models.KontrolerWyboruNauki wybor = new Models.KontrolerWyboruNauki();
				using (var client = new WcfService.Service1Client())
				{
					wybor.ListaWyboruNauki = await client.PobierzFormyNaukiAsync(Models.Token.NumerToken);
				}

				foreach (var item in wybor.ListaWyboruNauki.Select(x => x.Jezyk).Distinct().ToList())
					cmBxJezyk.Items.Add(item);
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd przy połączeniu z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void PobierzWszystkieSlowka()
		{
			List<WcfService.Slowka> listaSlowek = new List<WcfService.Slowka>();
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					listaSlowek = await client.PobierzWszystkieSlowkaDoSlownikaAsync(WybranyJezyk, Models.Token.NumerToken);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd przy połączeniu z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			this._slownikWindow.dgSlownik.ItemsSource = listaSlowek;
		}

		private void btnOk_Click(object sender, RoutedEventArgs e)
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			this._slownikWindow.tbxSlowko.Text = string.Empty;
			this._slownikWindow.dgtcKategoria.Visibility = Visibility.Hidden;
			this._slownikWindow.dgtcPoziom.Visibility = Visibility.Hidden;

			if (cmBxJezyk.SelectedIndex == -1)
				MessageBox.Show("Nie wybrano żadnej wartości!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			else
			{
				PobierzWszystkieSlowka();
				this.Close();
			}

		}
	}
}
