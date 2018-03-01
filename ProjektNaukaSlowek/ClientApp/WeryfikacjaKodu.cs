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
    public partial class WeryfikacjaKodu : Form
    {
        public WeryfikacjaKodu()
        {
            InitializeComponent();
        }

        private void Wroc_Click(object sender, EventArgs e)
        {
            PrzypomnienieHasla f = new PrzypomnienieHasla();
            f.Show();
            Opacity = 0;
        }

        private void ZmienHaslo_Click(object sender, EventArgs e)
        {
            Logowanie f = new Logowanie();
            f.Show();
            Opacity = 0;
        }
    }
}
