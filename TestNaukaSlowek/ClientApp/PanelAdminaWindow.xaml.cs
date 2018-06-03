using System.Windows;

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
