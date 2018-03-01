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
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Logowanie_Click(object sender, EventArgs e)
        {
            Logowanie f3 = new Logowanie();
            f3.Show();
            Opacity = 0;

        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja f2 = new Rejestracja();
            f2.Show();
            Opacity = 0;
        }
    }
}
