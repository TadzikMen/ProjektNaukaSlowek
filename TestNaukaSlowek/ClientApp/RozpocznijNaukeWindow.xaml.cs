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
	/// Interaction logic for RozpocznijNaukeWindow.xaml
	/// </summary>
	public partial class RozpocznijNaukeWindow : Window
	{ 
		public RozpocznijNaukeWindow()
		{
			InitializeComponent();
			PobierzFormyNauki();
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
		}

		private string PrzekazWybranyPoziom => cmBxWybierzPoziom.SelectedValue.ToString();

		private async void PobierzFormyNauki()
		{
			Models.KontrolerWyboruNauki wyborFormy = new Models.KontrolerWyboruNauki();

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					wyborFormy.ListaWyboruNauki = await client.PobierzFormyNaukiAsync(Models.Token.NumerToken);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					messageBoxText: $"Błąd pobierania danych z bazy danych!\nOpis błędu:\n{ex.ToString()}",
					caption: "Błąd",
					button: MessageBoxButton.OK,
					icon: MessageBoxImage.Error);
			}

			foreach (var item in wyborFormy.ListaWyboruNauki.Select(x => x.FormaNauki).Distinct().ToList())
				cmBxWybierzFormeNauki.Items.Add(item);

			foreach (var item in wyborFormy.ListaWyboruNauki.Select(x => x.Jezyk).Distinct().ToList())
				cmBxWybierzJezyk.Items.Add(item);

			foreach (var item in wyborFormy.ListaWyboruNauki.Select(x => x.Poziom).Distinct().ToList())
				cmBxWybierzPoziom.Items.Add(item);

		}

		private void PrzelaczOknoNauki()
		{
			Models.RozpoczynanieNauki rozpoczynanie;

			if (cmBxWybierzFormeNauki.SelectedIndex != -1)
			{
				rozpoczynanie = new Models.RozpoczynanieNauki(cmBxWybierzFormeNauki.SelectedItem.ToString());
				if (rozpoczynanie.FormaNauki == "Słownik")
				{
					SlownikWindow sw = new SlownikWindow();
					sw.Show();
					this.Close();
				}
				else
				{
					if (cmBxWybierzJezyk.SelectedIndex == -1 || cmBxWybierzPoziom.SelectedIndex == -1)
						MessageBox.Show("Nie wybrano wymaganych wartości z listy!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);

					else
					{
						rozpoczynanie.Jezyk = cmBxWybierzJezyk.SelectedItem.ToString();
						rozpoczynanie.Poziom = cmBxWybierzPoziom.SelectedItem.ToString();

						if (rozpoczynanie.FormaNauki == "Fiszki")
						{
							FiszkiWindow fw = new FiszkiWindow(rozpoczynanie.Jezyk, rozpoczynanie.Poziom);
							fw.Show();
							this.Close();
						}
                        else if (rozpoczynanie.FormaNauki == "Tlumaczenie")
                        {
                            Tlumaczenie fw = new Tlumaczenie(rozpoczynanie.Jezyk, rozpoczynanie.Poziom);
                            fw.Show();
                            this.Close();
                        }
                        else if (rozpoczynanie.FormaNauki == "Tłumaczenie słówek")
						{
							Tlumaczenie tlumaczenie = new Tlumaczenie(rozpoczynanie.Jezyk, rozpoczynanie.Poziom);
							tlumaczenie.Show();
							this.Close();
							
						}
						else if (rozpoczynanie.FormaNauki == "Tłumaczenie zdań")
						{
							TlumaczenieZdanWindow tzw = new TlumaczenieZdanWindow(rozpoczynanie.Jezyk);
							tzw.Show();
							this.Close();
						}
						else
							MessageBox.Show("Nie wybrano wymaganych wartości z listy!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);

					}
				}
			}

		}

		private void btnRozpocznij_Click(object sender, RoutedEventArgs e)
		{
			PrzelaczOknoNauki();
		}

		private void btnWroc_Click(object sender, RoutedEventArgs e)
		{
			AplikacjaWindow aw = new AplikacjaWindow();
			aw.Show();
			this.Close();
		}

		private void cmBxWybierzFormeNauki_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
		{
			if("Słownik" == cmBxWybierzFormeNauki.SelectedItem.ToString())
			{
				cmBxWybierzJezyk.Foreground = new SolidColorBrush(Colors.Gray);
				cmBxWybierzPoziom.Foreground = new SolidColorBrush(Colors.Gray);
				cmBxWybierzJezyk.IsEnabled = false;
				cmBxWybierzPoziom.IsEnabled = false;
			}
			else
			{
				cmBxWybierzJezyk.Foreground = new SolidColorBrush(Colors.Black);
				cmBxWybierzPoziom.Foreground = new SolidColorBrush(Colors.Black);
				cmBxWybierzJezyk.IsEnabled = true;
				cmBxWybierzPoziom.IsEnabled = true;
			}
		}

        private void cmBxWybierzJezyk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
