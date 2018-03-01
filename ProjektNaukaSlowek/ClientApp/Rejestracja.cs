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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();
        }

        StreamWriter sw;

        private void Zarejestruj_Click(object sender, EventArgs e)
        {
            MenuGlowne f = new MenuGlowne();
            sw = new StreamWriter("baza.txt");
            sw.WriteLine(Login.Text + " " + Haslo.Text + " " + Imie.Text + " " +Nazwisko.Text + " " + Email.Text);
            sw.Close();
            f.Show();
            Opacity = 0;
        }

        private void Wróć_Click(object sender, EventArgs e)
        {
            MenuGlowne f = new MenuGlowne();
            f.Show();
            Opacity = 0;
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {

        }
    }
}
