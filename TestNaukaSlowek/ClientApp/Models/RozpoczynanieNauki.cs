using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public class RozpoczynanieNauki
	{
		public string FormaNauki { get; set; }
		public string Jezyk { get; set; }
		public string Poziom { get; set; }

		public RozpoczynanieNauki()
		{

		}

		public RozpoczynanieNauki(string formaNauki)
		{
			this.FormaNauki = formaNauki;
		}

		public RozpoczynanieNauki(string formaNauki, string poziom, string jezyk)
		{
			this.Jezyk = jezyk;
			this.Poziom = poziom;
			this.FormaNauki = formaNauki;
		}

		public RozpoczynanieNauki PrzelaczanieOknaFormyNauki(string formaNauki, string jezyk, string poziom)
		{
			RozpoczynanieNauki rozpoczynanieNauki = new RozpoczynanieNauki();

			if (formaNauki.Contains("Słownik"))
			{
				rozpoczynanieNauki = new Models.RozpoczynanieNauki(formaNauki);
				return rozpoczynanieNauki;
			}

			else if (formaNauki.Contains("Fiszki"))
			{
				if (string.IsNullOrEmpty(jezyk) || string.IsNullOrEmpty(poziom))
					return null;
				else
				{
					rozpoczynanieNauki = new RozpoczynanieNauki(formaNauki, poziom, jezyk);
					return rozpoczynanieNauki;
				}
			}

			else if (formaNauki.Contains("Gramatyka"))
			{
				if (string.IsNullOrEmpty(jezyk) || string.IsNullOrEmpty(poziom))
					return null;
				else
				{
					rozpoczynanieNauki = new RozpoczynanieNauki(formaNauki, poziom, jezyk);
					return rozpoczynanieNauki;
				}
			}

			else
				return null;

		}
    }
}