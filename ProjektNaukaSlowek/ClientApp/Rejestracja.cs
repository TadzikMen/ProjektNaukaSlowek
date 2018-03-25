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
			pictureBox1.Visible = false;
        }
		private async void btnZarejestruj_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = true;
			this.Enabled = false;
			
			bool czyPoprawneDane = true;
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					Models.ObslugaRejestracji or = new Models.ObslugaRejestracji(
						tbxLogin.Text,
						tbxHaslo.Text,
						tbxEmail.Text,
						tbxImie.Text,
						tbxNazwisko.Text);
					
					czyPoprawneDane = or.SprawdzDaneWejsciowe(tbxLogin.Text, tbxHaslo.Text, tbxEmail.Text);
				//	or.Lista = await client.PobierzLoginyIMaileAsync();

					if (!or.SprawdzCzyIstniejeUzytkownik(or.Lista, tbxLogin.Text, tbxEmail.Text))
					{
						pictureBox1.Visible = false;
						this.Enabled = true;
						MessageBox.Show(this, "Podany użytkownik lub e-mail już został użyty!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else if (!czyPoprawneDane)
					{
						pictureBox1.Visible = false;
						this.Enabled = true;
						MessageBox.Show(this, "Wypełnij wszystkie pola!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else
					{
						await client.WyslijMailaRejestracjaAsync(or.Login, or.Haslo, or.Email, or.Imie, or.Nazwisko);
						await client.DodajUzytkownikaAsync(or.Login, or.Haslo, or.Email, or.Imie, or.Nazwisko);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				pictureBox1.Visible = false;
				MessageBox.Show(this, "Użytkownik został dodany pomyślnie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
				MenuGlowne f = new MenuGlowne();
				//WindowState = FormWindowState.Minimized;
				ShowInTaskbar = false;
				f.ShowDialog();
				this.Close();
			}
		}

		private void btnWróć_Click(object sender, EventArgs e)
		{
			MenuGlowne f = new MenuGlowne();
			//WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			f.ShowDialog();
			this.Close();
		}
	}
}
