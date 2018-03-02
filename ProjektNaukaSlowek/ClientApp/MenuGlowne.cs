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
            MenuGlowneInstance = this;
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Logowanie_Click(object sender, EventArgs e)
        {
            //Logowanie f3 = new Logowanie();
            //f3.ShowDialog();
            //this.Close();
            //Opacity = 0;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = false;

            //Open another form 
            Logowanie logowanie = new Logowanie
            {
                //since we open it from a minimezed window - it will not be focused unless we put it as TopMost.
                TopMost = true
            };
            logowanie.Show();
            //now that that it is topmost and shown - we want to set its behavior to be normal window again.
            logowanie.TopMost = false;
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja f2 = new Rejestracja();
            f2.Show();
            Opacity = 0;
        }
    }
}
