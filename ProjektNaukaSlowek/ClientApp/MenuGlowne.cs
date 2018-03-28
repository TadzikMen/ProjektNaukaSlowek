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
        public static MenuGlowne MenuGlowneInstance;

        public MenuGlowne()
        {
			System.Threading.Thread task = new System.Threading.Thread(new System.Threading.ThreadStart(SplashStart));
			task.Start();
			System.Threading.Thread.Sleep(5000);

            MenuGlowneInstance = this;

            InitializeComponent();
			task.Abort();
        }

		public void SplashStart()
		{
			Application.Run(new SplashScreen());
		}

		private void Logowanie_Click(object sender, EventArgs e)
		{
			Logowanie logowanie = new Logowanie();
			ShowInTaskbar = false;

			logowanie.ShowDialog();
			this.Close();
		}

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            ShowInTaskbar = false;
            rejestracja.ShowDialog();
            Opacity = 0;
            this.Close();
        }
    }
}
