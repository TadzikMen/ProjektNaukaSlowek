using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public class RozpoczynanieNauki
	{
		public RozpoczynanieNauki(string formaNauki, string jezyk, string poziom)
		{
			this.FormaNauki = formaNauki;
			this.WybranyJezyk = jezyk;
			this.Poziom = poziom;
		}

		public string FormaNauki { get; set; }
		public string WybranyJezyk { get; set; }
		public string Poziom { get; set; }
	}
}