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
	/// Interaction logic for PanelAdminaWindow.xaml
	/// </summary>
	public partial class PanelAdminaWindow : Window
	{
		public PanelAdminaWindow()
		{
			InitializeComponent();
		}

		private void btnDodajUzytkownika_Click(object sender, RoutedEventArgs e)
		{

		}

		private async void btnWyloguj_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					await client.WylogujUzytkownikaAsync(Models.Token.NumerToken);
				}
			}
			catch
			{
				MessageBox.Show("Nie udało się poprawnie wylogować użytkownika!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			MainWindow mw = new MainWindow();
			mw.Show();
			this.Close();
		}

		private void btnDodajSlowko_Click(object sender, RoutedEventArgs e)
		{
			DodawanieSlowkaWindow dsw = new DodawanieSlowkaWindow();
			dsw.ShowDialog();
		}
	}
}
