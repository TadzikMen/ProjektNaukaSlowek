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
    public partial class Logowanie : Form
    {
		Aplikacja frmAplikacja;
		PrzypomnienieHasla frmPrzypomnienieHasla;
        public Logowanie()
        {
            InitializeComponent();
        }

		public string PrzekazUzytkownika
		{
			get { return tbxLogin.Text; }
		}

        private void PrzypomnienieHasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			if (frmPrzypomnienieHasla == null)
			{
				frmPrzypomnienieHasla = new PrzypomnienieHasla();
				frmPrzypomnienieHasla.FormClosed += PrzypomnienieHasla_FormClosed;
			}

			frmPrzypomnienieHasla.Show(this);
			Hide();
		}

		private void PrzypomnienieHasla_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmPrzypomnienieHasla = null;
			Show();
		}

		private async void ZalogujSie_Click(object sender, EventArgs e)
		{
			Models.ObslugaLogowania obsLogowania = new Models.ObslugaLogowania();

			bool log = false;
			try
			{
				using (var client = new WcfService.Service1Client())
				{
					log = await client.SprawdzDaneLogowaniaAsync(tbxLogin.Text, tbxHaslo.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (log == true)
				{
					using (var client = new WcfService.Service1Client())
					{
						obsLogowania.DaneLogowania = await client.PrzekazDaneDoZalogowaniaAsync(tbxLogin.Text);
						
					}
					
					MessageBox.Show(this, "Zalogowano pomyślnie!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
					if (frmAplikacja == null)
					{
						frmAplikacja = new Aplikacja();
						frmAplikacja.FormClosed += Aplikacja_FormClosed;
					}
					frmAplikacja.Show(this);
					Hide();

					frmAplikacja.PobierzUzytkownika = obsLogowania.DaneLogowania.Login;
					tbxLogin.Text = null;
					tbxHaslo.Text = null;
                }
				else
				{
					MessageBox.Show(this, "Brak użytkownika w bazie!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					tbxLogin.Text = null;
					tbxHaslo.Text = null;
				}
					
			}
		}

		private void Wroc_Click(object sender, EventArgs e)
        {
			Owner.Show();
			Hide();
        }

		private void Aplikacja_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmAplikacja = null;
			Show();
		}

        private void tbxHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ZalogujSie_Click(sender,e);
            }
        }
    }
}
