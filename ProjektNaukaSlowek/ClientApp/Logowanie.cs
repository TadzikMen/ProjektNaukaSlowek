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
			bool log = false;
			try
			{
				//Wywołanie funkcji po stronie serwera
				using (var client = new WcfService.Service1Client())
				{
					log = await client.SprawdzDaneLogowaniaAsync(Login2.Text, Haslo2.Text);
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
					MessageBox.Show(this, "Zalogowano pomyślnie!", "Sukces!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show(this, "Brak użytkownika w bazie!", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Login2.Text = null;
					Haslo2.Text = null;
				}
					
			}
		}

		private void Wroc_Click(object sender, EventArgs e)
        {
            MenuGlowne f = new MenuGlowne();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
           

            ////Open another form Otwarcie wielu formatek, ale nie zamykają się(są ukryte i tworzone nowe instancje
            //MenuGlowne mg = new MenuGlowne
            //{
            //    TopMost = true
            //};
            //mg.Visible = true;
            f.ShowDialog();
          //  mg.TopMost = false;
            this.Close();
        }

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }
    }
}
