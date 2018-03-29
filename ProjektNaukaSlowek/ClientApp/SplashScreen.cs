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
	public partial class SplashScreen : Form
	{
		public SplashScreen()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			pasekPostepu.Increment(1);
			LblTimer.Text = pasekPostepu.Value.ToString() +"%";

			if (pasekPostepu.Value == 100)
				timer1.Stop();
		}
	}
}
