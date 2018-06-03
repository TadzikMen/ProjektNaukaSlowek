using System;
using System.Windows;

namespace ClientApp
{
	/// <summary>
	/// Interaction logic for RejestracjaWindow.xaml
	/// </summary>
	public partial class RejestracjaWindow : Window
	{
		Models.ObslugaRejestracji obsRejestracji;
		public RejestracjaWindow()
		{
			InitializeComponent();
		}

		private void btnPotwierdz_Click_1(object sender, RoutedEventArgs e)
		{
			
			ZarejestrujUzytkownika();
		}

		private void btnWroc_Click_1(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private async void ZarejestrujUzytkownika()
		{
			//SplashScreen splash = new SplashScreen("Images\\loading.gif");
			//splash.Show(true, false);
			bool czyPoprawneDane = true;
			bool weryfikacja = true;
			this.IsEnabled = false;

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					obsRejestracji = new Models.ObslugaRejestracji(
						tbxLogin.Text,
						tbxHaslo.Password,
						tbxPowtorzoneHaslo.Password,
						tbxEmail.Text,
						tbxImie.Text,
						tbxNazwisko.Text);

					czyPoprawneDane = obsRejestracji.SprawdzDaneWejsciowe(
						login: obsRejestracji.Login,
						haslo: obsRejestracji.Haslo,
						haslo2: obsRejestracji.Haslo2,
						email: obsRejestracji.Email);

					obsRejestracji.Lista = await client.PobierzLoginyMaileImionaAsync();
					
					if (!obsRejestracji.SprawdzCzyIstniejeUzytkownik(obsRejestracji.Lista, tbxLogin.Text, tbxEmail.Text))
					{
						weryfikacja = false;
						this.IsEnabled = true;
						MessageBox.Show(
							this, 
							"Podany użytkownik lub e-mail już został użyty!", 
							"Błąd!", 
							MessageBoxButton.OK, 
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else if (!czyPoprawneDane)
					{
						weryfikacja = false;
						this.IsEnabled = true;
						MessageBox.Show(
							this, 
							"Wypełnij wszystkie pola!", 
							"Błąd!", 
							MessageBoxButton.OK, 
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else if (!obsRejestracji.WalidacjaHasla(tbxHaslo.Password, tbxPowtorzoneHaslo.Password))
					{
						
						weryfikacja = false;
						this.IsEnabled = true;
						WyczyscPola();
						MessageBox.Show(
							this,
							"Haslo powinno mieć powyżej 8 znaków i posiadać conajmniej jedną dużą literę oraz cyfrę",
							"Błąd!", MessageBoxButton.OK,
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else if (tbxHaslo.Password != tbxPowtorzoneHaslo.Password)
					{
						weryfikacja = false;
						this.IsEnabled = true;
						WyczyscPola();
						MessageBox.Show(
							this, 
							"Podaj dwa takie same hasła", 
							"Błąd!", 
							MessageBoxButton.OK, 
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else if (!obsRejestracji.SprawdzenieEmail(tbxEmail.Text))
					{
						weryfikacja = false;
						this.IsEnabled = true;
						MessageBox.Show(
							this, 
							"Nieprawidlowy adres e-mail", 
							"Błąd!", 
							MessageBoxButton.OK, 
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else if (!obsRejestracji.SprawdzenieImieINazwisko(tbxImie.Text, tbxNazwisko.Text))
					{
						weryfikacja = false;
						this.IsEnabled = true;
						MessageBox.Show(
							this, 
							"Imie i nazwisko musi zaczynać się z wielkiej litery", 
							"Błąd!", 
							MessageBoxButton.OK, 
							MessageBoxImage.Error);
						WyczyscPola();
					}
					else
					{
						await client.WyslijMailaRejestracjaAsync(obsRejestracji.Login, obsRejestracji.Haslo, obsRejestracji.Email, obsRejestracji.Imie, obsRejestracji.Nazwisko);
						await client.DodajUzytkownikaAsync(obsRejestracji.Login, obsRejestracji.Haslo, obsRejestracji.Email, obsRejestracji.Imie, obsRejestracji.Nazwisko);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Błąd!", MessageBoxButton.OK, MessageBoxImage.Error);
				this.IsEnabled = true;
				weryfikacja = false;
			}
			finally
			{
				if (weryfikacja == true)
				{
					this.IsEnabled = true;
					MessageBox.Show(
						this,
						"Użytkownik został dodany pomyślnie!",
						"Informacja", MessageBoxButton.OK,
						MessageBoxImage.Information);

					WyczyscPola();
					this.DialogResult = true;
				}
			}
		}

		private void WyczyscPola()
		{
			//this.tbxEmail = null;
			//this.tbxHaslo = null;
			//this.tbxImie = null;
			//this.tbxLogin = null;
			//this.tbxNazwisko = null;
			//this.tbxPowtorzoneHaslo = null;
		}
	}
}
