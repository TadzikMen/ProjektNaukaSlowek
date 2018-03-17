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
			bool czyPoprawneDane = true;

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					//Models.ObslugaRejestracji obiektListy = new Models.ObslugaRejestracji();
					Models.ObslugaRejestracji or = new Models.ObslugaRejestracji();

					czyPoprawneDane = or.SprawdzDaneWejsciowe(tbxLogin.Text, tbxHaslo.Text, tbxImie.Text, tbxNazwisko.Text, tbxEmail.Text);
					or.Lista = await client.PobierzLoginyIMaileAsync();

					if (!or.SprawdzCzyIstniejeUzytkownik(or.Lista, tbxLogin.Text, tbxEmail.Text))
					{
						MessageBox.Show(this, "Podany użytkownik lub e-mail już został użyty!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else if (!czyPoprawneDane)
					{
						MessageBox.Show(this, "Wypełnij wszystkie pola!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					await client.DodajUzytkownikaAsync(tbxLogin.Text, tbxHaslo.Text, tbxImie.Text, tbxNazwisko.Text, tbxEmail.Text);
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
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
