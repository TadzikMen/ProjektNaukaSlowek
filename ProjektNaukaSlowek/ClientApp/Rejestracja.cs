using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ClientApp
{
    public partial class Rejestracja : Form
    {
		public Rejestracja()
        {
            InitializeComponent();
        }

		private async void btnZarejestruj_Click(object sender, EventArgs e)
		{
			bool czyPoprawneDane;

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					Models.ObslugaRejestracji obiektListy = new Models.ObslugaRejestracji();
					Models.ObslugaRejestracji or = new Models.ObslugaRejestracji();

					obiektListy.Lista = await client.PobierzLoginyIMaileAsync();
					czyPoprawneDane = or.SprawdzCzyIstniejeUzytkownik(obiektListy.Lista, tbxLogin.Text, tbxEmail.Text);
					await client.DodajUzytkownikaAsync(tbxLogin.Text, tbxHaslo.Text, tbxImie.Text, tbxNazwisko.Text, tbxEmail.Text);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.DialogResult = DialogResult.OK;
				MessageBox.Show(this, "Użytkownik został dodany pomyślnie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MenuGlowne f = new MenuGlowne();
				WindowState = FormWindowState.Minimized;
				ShowInTaskbar = false;
				f.ShowDialog();
				this.Close();
			}
		}

		private void btnWróć_Click(object sender, EventArgs e)
		{
			MenuGlowne f = new MenuGlowne();
			WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			f.ShowDialog();
			this.Close();
		}
	}
}
