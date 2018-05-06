﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public class RozpoczynanieNauki
	{
		private bool _sprawdzDaneWejsciowe;

		public string FormaNauki { get; set; }
		public string Jezyk { get; set; }
		public string Poziom { get; set; }
		public bool SprawdzDaneWejsciowe { get { return _sprawdzDaneWejsciowe; } set { _sprawdzDaneWejsciowe = value; } }

		public RozpoczynanieNauki(string jezyk, string poziom, string formaNauki)
		{
			this.Jezyk = jezyk;
			this.Poziom = poziom;
			this.FormaNauki = formaNauki;
			_sprawdzDaneWejsciowe = SprawdzPoprawnoscWyboru(this.Jezyk, this.Poziom, this.FormaNauki);
		}

		private bool SprawdzPoprawnoscWyboru(string jezyk, string poziom, string formaNauki)
		{
			if (string.IsNullOrEmpty(jezyk) || string.IsNullOrEmpty(poziom) || string.IsNullOrEmpty(formaNauki))
				return false;

			return true;
		}
    }
}
