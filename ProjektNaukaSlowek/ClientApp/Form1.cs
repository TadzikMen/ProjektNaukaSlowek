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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Logowanie_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            Opacity = 0;

        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            Opacity = 0;
        }
    }
}
