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

		public RozpoczynanieNauki(string formaNauki)
		{
			this.FormaNauki = formaNauki;
		}

		public RozpoczynanieNauki(string formaNauki, string poziom = null, string jezyk = null)
		{
			this.Jezyk = jezyk;
			this.Poziom = poziom;
			this.FormaNauki = formaNauki;
		}
    }
}
