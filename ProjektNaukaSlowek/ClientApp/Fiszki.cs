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
	public partial class Fiszki : Form
	{
		public Fiszki()
		{
			InitializeComponent();
			
		}

		public string PobierzNumerPoziomu
		{
			set { tbxNrPoziomu.Text = value; }
		}

		private void btnTlumacz_Click(object sender, EventArgs e)
		{

		}

		private void btnWroc_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}
	}
}
