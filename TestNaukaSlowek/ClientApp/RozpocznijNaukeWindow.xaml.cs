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

		private void btnRozpocznij_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Models.RozpoczynanieNauki rozpoczynanieNauki = new Models.RozpoczynanieNauki(
					jezyk: this.cmBxWybierzJezyk.SelectedItem.ToString(),
					poziom: this.cmBxWybierzPoziom.SelectedItem.ToString(),
					formaNauki: this.cmBxWybierzFormeNauki.SelectedItem.ToString());

				if (rozpoczynanieNauki.SprawdzDaneWejsciowe)
				{
					if (rozpoczynanieNauki.FormaNauki == "Fiszki")
					{
						FiszkiWindow fw = new FiszkiWindow(
							cmBxWybierzJezyk.SelectedItem.ToString(),
							cmBxWybierzPoziom.SelectedItem.ToString());

						fw.Show();
						this.Close();
					}
					if (rozpoczynanieNauki.FormaNauki == "Słownik")
					{
						SlownikWindow sw = new SlownikWindow();
						sw.Show();
						this.Close();
					}
				}
			}
			catch
			{
				MessageBox.Show(
					$"Brak wybranych wartości. Wybierz wartości z listy rozwijanej!",
					"Błąd!",
					MessageBoxButton.OK,
					MessageBoxImage.Error);
			}
		}

		private void btnWroc_Click(object sender, RoutedEventArgs e)
		{
			AplikacjaWindow aw = new AplikacjaWindow();
			aw.Show();
			this.Close();
		}
	}
}
