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
        public Logowanie()
        {
            InitializeComponent();
        }

        private void PrzypomnienieHasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrzypomnienieHasla f = new PrzypomnienieHasla();
            this.Visible = false;
            f.ShowDialog();
            Opacity = 0;
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
						obsLogowania.Login = await client.PrzekazDaneDoZalogowaniaAsync(tbxLogin.Text);
					}
					MessageBox.Show(this, "Zalogowano pomyślnie!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Aplikacja f = new Aplikacja();
                    ShowInTaskbar = false;
                    f.ShowDialog();
                    this.Close();
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
            MenuGlowne f = new MenuGlowne();
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }
        
    }
}
