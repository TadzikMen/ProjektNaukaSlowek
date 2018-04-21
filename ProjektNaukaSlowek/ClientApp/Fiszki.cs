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
		public Fiszki(string jezyk, string poziom)
		{
			InitializeComponent();

			txbxJezyk.Text = jezyk;
			txbxPoziom.Text = poziom;

		}

		private async void PobierzSlowko()
		{
			WcfService.Slowka slowko = new WcfService.Slowka();
			using (var client = new WcfService.Service1Client())
			{
				slowko = await client.LosujSlowkoDoFiszkiAsync(txbxJezyk.Text, cmbbxKategoria.SelectedText, cmbbxKategoria.SelectedText, Models.Token.NumerToken);
			}
		}

		private void btnTlumacz_Click(object sender, EventArgs e)
		{

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
