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
    public partial class Aplikacja : Form
    {
        public Aplikacja()
        {
            InitializeComponent();
        }

		public string PobierzUzytkownika
		{
			set { lblNazwa.Text += value; }
		}

        private void btnEdytujProfil_Click(object sender, EventArgs e)
        {
            EdycjaUseraAdmina f = new EdycjaUseraAdmina();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnRozpocznijNauke_Click(object sender, EventArgs e)
        {
            RozpocznijNauke f = new RozpocznijNauke();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnKontynuujNauke_Click(object sender, EventArgs e)
        {
            KontynuujNauke f = new KontynuujNauke();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnSprawdzPostepy_Click(object sender, EventArgs e)
        {
            SprawdzSwojePostepy f = new SprawdzSwojePostepy();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnZarzadzaj_Click(object sender, EventArgs e)
        {
            Zarzadzaj f = new Zarzadzaj();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }

        private void btnZobaczOsiagniecia_Click(object sender, EventArgs e)
        {
            ZobaczSwojeOsiagniecia f = new ZobaczSwojeOsiagniecia();
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            f.ShowDialog();
            this.Close();
        }
    }
}
