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
		System.Threading.Thread oczekiwanie;
		public Rejestracja()
        {
            InitializeComponent();
        }

        public bool WalidacjaHasla(string haslo)
        {
            if(haslo.Length < 8)
                return false;
            
            else
            {
				if ((haslo.Any(c => char.IsUpper(c))) && haslo.Any(c => char.IsDigit(c)))
					return true;

				else
					return false;
            }
        }

		private bool SprawdzenieEmail(string email)
		{
			//(@) Dopasowanie znaku @. Jest to pierwsza grupa przechwytywania.
			//(.+) Odpowiada jedno lub więcej wystąpień dowolnego znaku. Jest to druga grupa przechwytywania.
			//$	Zakończenie dopasowuje koniec ciągu.

			// Przykładowe interpretacje funkcji:
			//       Poprawne: david.jones@proseware.com
			//       Poprawne: d.j@server1.proseware.com
			//       Poprawne: jones@ms1.proseware.com
			//       Niepoprawne: j.@server1.proseware.com
			//       Poprawne: j@proseware.com9
			//       Poprawne: js#internal@proseware.com
			//       Poprawne: j_9@[129.126.118.1]
			//       Niepoprawne: j..s@proseware.com
			//       Niepoprawne: js*@proseware.com
			//       Niepoprawne: js@proseware..com
			//       Poprawne: js@proseware.com9
			//       Poprawne: j.s@server1.proseware.com
			if (string.IsNullOrEmpty(email))
				return false;
			else if (System.Text.RegularExpressions.Regex.IsMatch(
				email,
				@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
				System.Text.RegularExpressions.RegexOptions.IgnoreCase)
				)
				return true;
			else
				return false;


		}

		private bool SprawdzenieImieINazwisko(string imie, string nazwisko)
        {
			if (imie == string.Empty || nazwisko == string.Empty)
				return true;
            else if(Convert.ToInt32(imie[0]) > 65 && Convert.ToInt32(imie[0]) < 90 && Convert.ToInt32(nazwisko[0]) > 65 && Convert.ToInt32(nazwisko[0]) < 90)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		public void WyswietlOczekiwanie()
		{
			Application.Run(new Oczekiwanie());
		}

		private async void btnZarejestruj_Click(object sender, EventArgs e)
		{
			oczekiwanie = new System.Threading.Thread(WyswietlOczekiwanie);
			oczekiwanie.Start();
			this.Enabled = false;
						
			bool czyPoprawneDane = true;
            bool weryfikacja = true;

			try
			{
				using (var client = new WcfService.Service1Client())
				{
					Models.ObslugaRejestracji obsRejestracji = new Models.ObslugaRejestracji(
						tbxLogin.Text,
						tbxHaslo.Text,
						tbxEmail.Text,
						tbxImie.Text,
						tbxNazwisko.Text);
					
					czyPoprawneDane = obsRejestracji.SprawdzDaneWejsciowe(tbxLogin.Text, tbxHaslo.Text, tbxEmail.Text);
					obsRejestracji.Lista = await client.PobierzLoginyIMaileAsync();

                    if (!obsRejestracji.SprawdzCzyIstniejeUzytkownik(obsRejestracji.Lista, tbxLogin.Text, tbxEmail.Text))
					{
						oczekiwanie.Abort();
						weryfikacja = false;
                        this.Enabled = true;
						MessageBox.Show(this, "Podany użytkownik lub e-mail już został użyty!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						WyczyscPola();
						return;
					}
					else if (!czyPoprawneDane)
					{
						oczekiwanie.Abort();
						weryfikacja = false;
                        this.Enabled = true;
						MessageBox.Show(this, "Wypełnij wszystkie pola!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						WyczyscPola();
						return;
					}
                    else if (!WalidacjaHasla(tbxHaslo.Text))
                    {
						oczekiwanie.Abort();
						weryfikacja = false;
                        this.Enabled = true;
						WyczyscPola();
						MessageBox.Show(this, "Haslo powinno mieć powyżej 8 znaków i posiadać conajmniej jedną dużą literę oraz cyfrę", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!SprawdzenieEmail(tbxEmail.Text))
                    {
						oczekiwanie.Abort();
						weryfikacja = false;
                        this.Enabled = true;
                        MessageBox.Show(this, "Nieprawidlowy adres e-mail", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
						WyczyscPola();
					}
                    else if (!SprawdzenieImieINazwisko(tbxImie.Text,tbxNazwisko.Text))
                    {
						oczekiwanie.Abort();
						weryfikacja = false;
                        this.Enabled = true;
                        MessageBox.Show(this, "Imie i nazwisko musi zaczynać się z wielkiej litery", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				oczekiwanie.Abort();
				MessageBox.Show(this, ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				weryfikacja = false;
			}
			finally
			{
				oczekiwanie.Abort();
                if (weryfikacja == true)
                {
					this.Enabled = true;
                    MessageBox.Show(this, "Użytkownik został dodany pomyślnie!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
					WyczyscPola();
					Owner.Show();
					Hide();
				}
			}
		}

		private void WyczyscPola()
		{
			tbxLogin.Text = null;
			tbxHaslo.Text = null;
			tbxImie.Text = null;
			tbxNazwisko.Text = null;
			tbxEmail.Text = null;
		}

		private void btnWróć_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
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
