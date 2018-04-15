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
    public partial class RozpocznijNauke : Form
    {
		Fiszki frmFiszki;
		public RozpocznijNauke()
		{
			InitializeComponent();

			//Do późniejszej poprawy
			UzupelnijWartosci();

		}
        
        public string PrzekazNumerPoziomu
		{
			get { return cmBxWyborPoziomu.SelectedItem.ToString(); }
		}

		private void UzupelnijWartosci()
		{
			cmBxFormaNauki.Items.Add("Pełny Kurs");
			cmBxFormaNauki.Items.Add("Fiszki");
			cmBxFormaNauki.Items.Add("Gramatyka");
            cmBxFormaNauki.Items.Add("Słownik");

            cmBxWyborJezyka.Items.Add("Angielski");
			cmBxWyborJezyka.Items.Add("Niemiecki");
			cmBxWyborJezyka.Items.Add("Hiszpański");

			cmBxWyborPoziomu.Items.Add("Podstawowy");
			cmBxWyborPoziomu.Items.Add("Średniozaawansowany");
			cmBxWyborPoziomu.Items.Add("Zaawansowany");
		}

		private void btnWroc_Click(object sender, EventArgs e)
		{
			Owner.Show();
			Hide();
		}

		private void btnRozpocznij_Click(object sender, EventArgs e)
		{
			Models.RozpoczynanieNauki rozpoczynanieNauki = new Models.RozpoczynanieNauki(
				cmBxFormaNauki.SelectedItem.ToString(),
				cmBxWyborJezyka.SelectedItem.ToString(),
				cmBxWyborPoziomu.SelectedItem.ToString()
				);

			if (rozpoczynanieNauki.FormaNauki == "Fiszki")
			{
				if (frmFiszki == null)
				{
					frmFiszki = new Fiszki(cmBxWyborJezyka.SelectedItem.ToString(), cmBxWyborPoziomu.SelectedItem.ToString());
					frmFiszki.FormClosed += Fiszki_FormClosed;
				}
				frmFiszki.Show(this);
				Hide();
			}
		}

		private void Fiszki_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmFiszki = null;
			Show();
		}

        private void RozpocznijNauke_Load(object sender, EventArgs e)
        {

        }

        private void cmBxFormaNauki_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmBxFormaNauki.SelectedItem.ToString() == "Słownik")
            {
                cmBxWyborJezyka.Enabled = false;
                cmBxWyborPoziomu.Enabled = false;
            }
            else
            {
                cmBxWyborJezyka.Enabled = true;
                cmBxWyborPoziomu.Enabled = true;
            }
        }
    }
}
