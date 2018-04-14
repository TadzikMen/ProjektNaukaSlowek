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
    public partial class MenuGlowne : Form
    {
		Logowanie frmLogowanie;
		Rejestracja frmRejestracja;
		
		public MenuGlowne()
		{
			if (!Models.ObslugaSplashScreena.czySplashZostalOdpalony)
			{
				System.Threading.Thread task = new System.Threading.Thread(new System.Threading.ThreadStart(SplashStart));
				task.Start();
				System.Threading.Thread.Sleep(5000);
				Models.ObslugaSplashScreena.czySplashZostalOdpalony = true;
				task.Abort();
			}
			InitializeComponent();
			
			Models.ObslugaSplashScreena.czySplashZostalOdpalony = true;
		}

		public void SplashStart()
		{
			Application.Run(new SplashScreen());
		}

		private void Logowanie_Click(object sender, EventArgs e)
		{
            //if (frmLogowanie == null)
            //{
            //	frmLogowanie = new Logowanie();
            //	frmLogowanie.FormClosed += Logowanie_FormClosed;
            //}
            //frmLogowanie.Show(this);
            Slownik f = new Slownik();
            f.ShowDialog();
			Hide();
		}

		private void Logowanie_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmLogowanie = null;
			Show();
		}

        private void Rejestracja_Click(object sender, EventArgs e)
        {
			if (frmRejestracja == null)
			{
				frmRejestracja = new Rejestracja();
				frmRejestracja.FormClosed += Logowanie_FormClosed;
			}

			frmRejestracja.Show(this);
			Hide();
		}

		private void Rejestracja_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmRejestracja = null;
			Show();
		}
	}
}
