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

        public bool Haslo(string haslo)
        {
            bool DuzeLitery = false;
            bool Cyfry = false;
            if(haslo.Length < 8)
            {
                return false;
            }
            else
            {
                foreach(var item in haslo) //opcjonalnie, do rozbudowania o znaki specjalne
                {
                    if(Convert.ToInt32( item) > 65 && Convert.ToInt32(item) < 90 )
                    {
                        DuzeLitery = true;
                    }
                    if (Convert.ToInt32(item) > 48 && Convert.ToInt32(item) < 57)
                    {
                        Cyfry = true;
                    }

                }
                if(DuzeLitery == false || Cyfry == false)
                {
                   
                    return false;
                }
            }
            return true;
        }

        private bool SprawdzenieEmail(string Email)
        {
            foreach (var item in Email)
            {
                if (item == '@')
                {
                    return true;
                }
               else
                {
                }
            }
            return false;
        }

        private bool SprawdzenieImieINazwisko(string imie, string nazwisko)
        {
            if(Convert.ToInt32(imie[0]) > 65 && Convert.ToInt32(imie[0]) < 90 && Convert.ToInt32(nazwisko[0]) > 65 && Convert.ToInt32(nazwisko[0]) < 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
		private async void btnZarejestruj_Click(object sender, EventArgs e)
		{
			pictureBox1.Visible = true;
			this.Enabled = false;
			
			bool czyPoprawneDane = true;
            bool weryfikacja = true;
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
					or.Lista = await client.PobierzLoginyIMaileAsync();

                   
                    if (!or.SprawdzCzyIstniejeUzytkownik(or.Lista, tbxLogin.Text, tbxEmail.Text))
					{
						pictureBox1.Visible = false;
                        weryfikacja = false;
                        this.Enabled = true;
						MessageBox.Show(this, "Podany użytkownik lub e-mail już został użyty!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					else if (!czyPoprawneDane)
					{
						pictureBox1.Visible = false;
                        weryfikacja = false;
                        this.Enabled = true;
						MessageBox.Show(this, "Wypełnij wszystkie pola!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
                    else if (!Haslo(tbxHaslo.Text))
                    {
                        pictureBox1.Visible = false;
                        weryfikacja = false;
                        this.Enabled = true;
                        MessageBox.Show(this, "Haslo powinno mieć powyżej 8 znaków i posiadać conajmniej jedną dużą literę oraz cyfrę", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!SprawdzenieEmail(tbxEmail.Text))
                    {
                        pictureBox1.Visible = false;
                        weryfikacja = false;
                        this.Enabled = true;
                        MessageBox.Show(this, "Nieprawidlowy adres e-mail", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!SprawdzenieImieINazwisko(tbxImie.Text,tbxNazwisko.Text))
                    {
                        pictureBox1.Visible = false;
                        weryfikacja = false;
                        this.Enabled = true;
                        MessageBox.Show(this, "Imie i nazwisko musi zaczynać się z wielkiej litery", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (weryfikacja == true)
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
		}

		private void btnWróć_Click(object sender, EventArgs e)
		{
			MenuGlowne f = new MenuGlowne();
			//WindowState = FormWindowState.Minimized;
			ShowInTaskbar = false;
			f.ShowDialog();
			this.Close();
		}

        private void tbxEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnZarejestruj_Click(sender, e);
            }
        }
    }
}
