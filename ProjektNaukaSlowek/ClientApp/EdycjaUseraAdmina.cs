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
    public partial class EdycjaUseraAdmina : Form
    {
        public EdycjaUseraAdmina()
        {
            InitializeComponent();
        }

		private void btnZatwierdzZmiany_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}

		private void btnWroc_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}
	}
}
