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
        public RozpocznijNauke()
        {
            InitializeComponent();
			//Do późniejszej poprawy KONIECZNIE
			cmBxFormaNauki.Items.Add("Pełny Kurs");
			cmBxFormaNauki.Items.Add("Fiszki");
			cmBxFormaNauki.Items.Add("Gramatyka");

			cmBxWyborJezyka.Items.Add("Angielski");
			cmBxWyborJezyka.Items.Add("Niemiecki");
			cmBxWyborJezyka.Items.Add("Hiszpański");

			cmBxWyborPoziomu.Items.Add("Podstawowy");
			cmBxWyborPoziomu.Items.Add("Średniozaawansowany");
			cmBxWyborPoziomu.Items.Add("Zaawansowany");
		}
    }
}
