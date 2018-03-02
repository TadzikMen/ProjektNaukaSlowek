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
            //MenuGlowne.MenuGlowneInstance.Close();
        }
        StreamReader sr;
        string tekst, login2, haslo2;
        int dlugosc, l=0;

        private void PrzypomnienieHasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrzypomnienieHasla f = new PrzypomnienieHasla();
            f.Show();
            Opacity = 0;
        }

        char spacja;

		private void ZalogujSie_Click(object sender, EventArgs e)
		{
			//using (var client = new Wcf.Service1Client())
			//{
			//	bool czyPoprawneDane = client.
			//}

            //weryfikacja logowania
			sr = new StreamReader("baza.txt");
			tekst = sr.ReadLine();
			dlugosc = tekst.Length;

			for (int i = 0; i < dlugosc; i++)
			{
				spacja = Convert.ToChar(tekst[i]);
				if (spacja == 32)
				{
					if (l > 0)
						i = dlugosc;
					l++;
				}
				if (l == 0)
					login2 += tekst[i];
				else if (i != dlugosc && spacja != 32)
					haslo2 += tekst[i];

			}
			if (Login2.Text == login2 && Haslo2.Text == haslo2)
			{
				MessageBox.Show("Zalogowano");
			}
			else
				MessageBox.Show("Niepoprawny login lub/i hasło");

            MenuGlowne f = new MenuGlowne();
            f.Show();
            Opacity = 0;


		}

		private void Wroc_Click(object sender, EventArgs e)
        {
            MenuGlowne f = new MenuGlowne();
            //f.Show();
            //Opacity = 0;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            //Open another form 
            MenuGlowne mg = new MenuGlowne
            {
                //since we open it from a minimezed window - it will not be focused unless we put it as TopMost.
                TopMost = true
            };
            mg.Show();
            //now that that it is topmost and shown - we want to set its behavior to be normal window again.
            mg.TopMost = false;
        }
    }
}
