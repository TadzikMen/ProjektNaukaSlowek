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
		EdycjaUseraAdmina frmEdycjaUseraAdmina;
		RozpocznijNauke frmRozpocznijNauke;
		KontynuujNauke frmKontynuujNauke;
		SprawdzSwojePostepy frmSprawdzSwojePostepy;
		Zarzadzaj frmZarzadzaj;
		ZobaczSwojeOsiagniecia frmZobaczSwojeOsiagniecia;

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
			if (frmEdycjaUseraAdmina == null)
			{
				frmEdycjaUseraAdmina = new EdycjaUseraAdmina();
				frmEdycjaUseraAdmina.FormClosed += EdycjaUseraAdmina_FormClosed;
			}

			frmEdycjaUseraAdmina.Show(this);
			Hide();
		}

		private void EdycjaUseraAdmina_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmEdycjaUseraAdmina = null;
			Show();
		}

		private void btnRozpocznijNauke_Click(object sender, EventArgs e)
        {
			if (frmRozpocznijNauke == null)
			{
				frmRozpocznijNauke = new RozpocznijNauke();
				frmRozpocznijNauke.FormClosed += RozpocznijNauke_FormClosed;
			}

			frmRozpocznijNauke.Show(this);
			Hide();
		}

		private void RozpocznijNauke_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmRozpocznijNauke = null;
			Show();
		}

		private void btnKontynuujNauke_Click(object sender, EventArgs e)
        {
			if (frmKontynuujNauke == null)
			{
				frmKontynuujNauke = new KontynuujNauke();
				frmKontynuujNauke.FormClosed += KontynuujNauke_FormClosed;
			}

			frmKontynuujNauke.Show(this);
			Hide();
		}

		private void KontynuujNauke_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmKontynuujNauke = null;
			Show();
		}

		private void btnSprawdzPostepy_Click(object sender, EventArgs e)
        {
			if (frmSprawdzSwojePostepy == null)
			{
				frmSprawdzSwojePostepy = new SprawdzSwojePostepy();
				frmSprawdzSwojePostepy.FormClosed += SprawdzSwojePostepy_FormClosed;
			}

			frmSprawdzSwojePostepy.Show(this);
			Hide();
		}

		private void SprawdzSwojePostepy_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmSprawdzSwojePostepy = null;
			Show();
		}

		private void btnZarzadzaj_Click(object sender, EventArgs e)
        {
			if (frmZarzadzaj == null)
			{
				frmZarzadzaj = new Zarzadzaj();
				frmZarzadzaj.FormClosed += Zarzadzaj_FormClosed;
			}

			frmZarzadzaj.Show(this);
			Hide();
		}

		private void Zarzadzaj_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmZarzadzaj = null;
			Show();
		}

		private void btnZobaczOsiagniecia_Click(object sender, EventArgs e)
        {
			if (frmZobaczSwojeOsiagniecia == null)
			{
				frmZobaczSwojeOsiagniecia = new ZobaczSwojeOsiagniecia();
				frmZobaczSwojeOsiagniecia.FormClosed += ZobaczOsiagniecia_FormClosed;
			}

			frmZobaczSwojeOsiagniecia.Show(this);
			Hide();
		}

		private void ZobaczOsiagniecia_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmZobaczSwojeOsiagniecia = null;
			Show();
		}

		private void btnWyloguj_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}
	}
}
