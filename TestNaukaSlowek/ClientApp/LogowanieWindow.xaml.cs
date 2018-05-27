using System;
using System.Windows;
using System.Windows.Input;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for LogowanieWindow.xaml
    /// </summary>
    public partial class LogowanieWindow : Window
    {
        public LogowanieWindow()
        {
            InitializeComponent();
        }

		private void btnZaloguj_Click(object sender, RoutedEventArgs e)
		{
			ZalogujUzytkownika();
		}

        private void KlikNaEnter(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                ZalogujUzytkownika();
            }
        }
        private async void ZalogujUzytkownika()
		{

            Grid1.IsEnabled = false;
            Models.ObslugaLogowania obsLogowania = new Models.ObslugaLogowania();
			bool czyPoprawneDane = false;

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					czyPoprawneDane = await client.SprawdzDaneLogowaniaAsync(tbxLogin.Text, passBox.Password);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			finally
			{
				if (czyPoprawneDane == true)
				{
					try
					{
						using (var client = new WcfService.Service1Client())
						{
							WcfService.Sesja sesja = new WcfService.Sesja();
							obsLogowania.DaneLogowania = await client.PrzekazDaneDoZalogowaniaAsync(tbxLogin.Text);
							sesja = await client.GenerujTokenAsync(obsLogowania.DaneLogowania.Login);
							Models.Token.NumerToken = sesja.Token;
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, ex.ToString(), "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
					}
					MessageBox.Show(this, "Zalogowano pomyślnie!", "Sukces!", MessageBoxButton.OK, MessageBoxImage.Information);
					
					tbxLogin.Text = null;
					passBox.Password = null;

					AplikacjaWindow aw = new AplikacjaWindow();
					aw.Show();
					this.Close();
				}
				else
				{
					MessageBox.Show(this, "Brak użytkownika w bazie!", "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
					passBox.Password = null;
                    Grid1.IsEnabled = true;
                }

			}
		}

		private void btnWroc_Click(object sender, RoutedEventArgs e)
		{
			MainWindow mw = new MainWindow();

			mw.Show();
			this.Close();
		}
	}
}
