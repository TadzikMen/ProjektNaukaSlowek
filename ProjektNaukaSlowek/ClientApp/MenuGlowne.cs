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

        private void Logowanie_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            //f3.ShowDialog();
            //this.Close();
            //Opacity = 0;
            WindowState = FormWindowState.Minimized;
           ShowInTaskbar = false;

          //  Otwarcie wielu formatek, ale nie zamykają się(są ukryte i tworzone nowe instancje
            //Open another form 
           // Logowanie logowanie = new Logowanie
            //{ 
            //    //since we open it from a minimezed window - it will not be focused unless we put it as TopMost.
            //    TopMost = true
            //};
            logowanie.ShowDialog();
            //now that that it is topmost and shown - we want to set its behavior to be normal window again.
          //  logowanie.TopMost = false;
            this.Close();
        }

        private void Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracja = new Rejestracja();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            rejestracja.ShowDialog();
            Opacity = 0;
            this.Close();
        }
    }
}
