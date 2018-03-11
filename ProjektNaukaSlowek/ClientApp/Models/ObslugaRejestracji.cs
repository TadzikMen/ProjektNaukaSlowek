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
			foreach (var item in daneWejsciowe)
			{
				if (item.Login == login || item.Email == email)
					return false;
			}

			return true;
		}

		private List<WcfService.Uwierzytelnianie> _lista;
	}
}
