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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        StreamReader sr;
        string tekst, login2, haslo2;
        int dlugosc, l=0;
        char spacja;

		private void ZalogujSie_Click(object sender, EventArgs e)
		{
			//using (var client = new Wcf.Service1Client())
			//{
			//	bool czyPoprawneDane = client.
			//}

			sr = new StreamReader("baza.txt");
			tekst = sr.ReadLine();
			dlugosc = tekst.Length;

			for (int i = 0; i < dlugosc; i++)
			{
				spacja = Convert.ToChar(tekst[i]);
				if (spacja == 32)
				{
					if (l > 0)
						i = dlugosc;
					l++;
				}
				if (l == 0)
					login2 += tekst[i];
				else if (i != dlugosc && spacja != 32)
					haslo2 += tekst[i];

			}
			if (Login2.Text == login2 && Haslo2.Text == haslo2)
			{
				MessageBox.Show("Zalogowano");
			}
			else
				MessageBox.Show("Niepoprawny login lub/i hasło");
			Form1 f = new Form1();
			f.Show();
			Opacity = 0;


		}

		private void Wroc_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Opacity = 0;
        }
    }
}
