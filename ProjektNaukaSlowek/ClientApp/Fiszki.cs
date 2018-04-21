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

			txbxJezyk.Text = jezyk;
			txbxPoziom.Text = poziom;
			PrzekazWszystkieKategorie();
		}

		private async void PrzekazWszystkieKategorie()
		{
			List<WcfService.Slowka> kategorie = new List<WcfService.Slowka>();
			using (var client = new WcfService.Service1Client())
			{
				kategorie = await client.PobierzKategorieAsync(Models.Token.NumerToken);
				foreach (var item in kategorie)
				{
					cmbbxKategoria.Items.Add(item.Kategoria);
				}

			}
			cmbbxKategoria.SelectedIndex = 0;
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
			txbSlowkoPolskie.Text = slowko.Tlumaczenie;
		}

		private void btnTlumacz_Click(object sender, EventArgs e)
		{
			txbTlumaczenie.Text = slowko.Slowko;
		}

		private void btnWroc_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}

        private void Fiszki_Load(object sender, EventArgs e)
        {

        }

        private void btnKolejneSlowko_Click(object sender, EventArgs e)
        {
			txbTlumaczenie.Text = null;
			PobierzSlowko();
        }
    }
}
