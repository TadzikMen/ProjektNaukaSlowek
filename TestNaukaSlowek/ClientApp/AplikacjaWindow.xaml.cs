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
    /// Interaction logic for AplikacjaWindow.xaml
    /// </summary>
    public partial class AplikacjaWindow : Window
    {
		static bool czyAdmin;
		public AplikacjaWindow()
        {
            InitializeComponent();
			WyswietlPowitanie();
			SprawdzCzyAdmin();
		}

		private async void SprawdzCzyAdmin()
		{
			try
			{
				WcfService.Rejestracja loginUsera = new WcfService.Rejestracja(); 
				using (var client = new WcfService.Service1Client())
				{
					loginUsera = await client.WyswietlEkranPowitalnyAsync(Models.Token.NumerToken);
					czyAdmin = await client.SprawdzCzyUzytkownikJestAdminemAsync(loginUsera.Login);
					if (czyAdmin)
						btnPanelAdmina.Visibility = Visibility.Visible;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Błąd przy połączeniu z serwerem!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}

		private async void WyswietlPowitanie()
		{
			WcfService.Rejestracja powitanie = new WcfService.Rejestracja();

			using (var client=new WcfService.Service1Client())
			{
				powitanie = await client.WyswietlEkranPowitalnyAsync(Models.Token.NumerToken);
			}

			lblUsername.Content = (string.IsNullOrEmpty(powitanie.Imie) ? $"Witaj, {powitanie.Login}!" : $"Witaj, {powitanie.Imie}!");
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

		private void btnRozpocznijNauke_Click(object sender, RoutedEventArgs e)
		{
			RozpocznijNaukeWindow rozpocznijWindow = new RozpocznijNaukeWindow();
			rozpocznijWindow.Show();
			this.Close();
		}


        private void btnKontynuujNauke_Click_1(object sender, RoutedEventArgs e)
        {
            KontynuujNauke KontynuujNauke = new KontynuujNauke();
            KontynuujNauke.Show();
            this.Close();
        }

		private void btnPanelAdmina_Click(object sender, RoutedEventArgs e)
		{
			PanelAdminaWindow paw = new PanelAdminaWindow();
			paw.Show();
			this.Close();
		}
	}
}