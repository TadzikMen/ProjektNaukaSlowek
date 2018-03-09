using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.WcfService;

namespace ClientApp.Models
{
	public class ObslugaRejestracji
	{
		public List<Uwierzytelnianie> Lista { get => _lista; set => _lista = value; }
		public bool SprawdzCzyIstniejeUzytkownik(List<Uwierzytelnianie> daneWejsciowe, string login, string email)
		{
			for (int i = 0; i < daneWejsciowe.Count; i++)
			{
				if (daneWejsciowe[i].Login == login || daneWejsciowe[i].Email == email)
					return false;
			}

			return true;
		}

		private List<WcfService.Uwierzytelnianie> _lista;
	}
}
