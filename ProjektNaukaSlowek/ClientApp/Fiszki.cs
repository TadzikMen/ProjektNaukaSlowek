using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
	public partial class Fiszki : Form
	{
		WcfService.Slowka slowko = new WcfService.Slowka();
		public Fiszki(string jezyk, string poziom)
		{
			InitializeComponent();

			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			txbxJezyk.Text = jezyk;
			txbxPoziom.Text = poziom;
			PrzekazWszystkieKategorie();
		}

		private async void PrzekazWszystkieKategorie()
		{
			List<WcfService.Slowka> kategorie = new List<WcfService.Slowka>();
			using (var client = new WcfService.Service1Client())
			{
				kategorie = await client.PobierzKategorieAsync(txbxPoziom.Text, Models.Token.NumerToken);
				foreach (var item in kategorie)
				{
					cmbbxKategoria.Items.Add(item.Kategoria);
				}
			}
		}

		private async void PobierzSlowko()
		{
			using (var client = new WcfService.Service1Client())
			{
				slowko = await client.LosujSlowkoDoFiszkiAsync(
					txbxJezyk.Text, 
					txbxPoziom.Text, 
					cmbbxKategoria.SelectedItem.ToString(), 
					Models.Token.NumerToken);
			}
			if (slowko.Tlumaczenie == null)
			{
				MessageBox.Show(this, "Brak słówek dla danej kategorii", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txbSlowkoPolskie.Text = null;
				txbTlumaczenie.Text = null;
				return;
			}
			txbSlowkoPolskie.Text = slowko.Tlumaczenie;

		}

		private void btnTlumacz_Click(object sender, EventArgs e)
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			txbTlumaczenie.Text = slowko.Slowko;
		}

		private void btnWroc_Click(object sender, EventArgs e)
		{
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			Owner.Show();
			Hide();
		}

        private void btnKolejneSlowko_Click(object sender, EventArgs e)
        {
			txbTlumaczenie.Text = null;
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
			PobierzSlowko();
		}

        private void cmbbxKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
			txbTlumaczenie.Text = null;
			Models.AktualizacjaCzasuPracy.AktualizujSesjeUzytkownika();
            PobierzSlowko();
        }
    }
}