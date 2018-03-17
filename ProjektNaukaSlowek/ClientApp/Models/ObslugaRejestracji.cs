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
		private List<WcfService.Uwierzytelnianie> _lista;
		public List<Uwierzytelnianie> Lista { get => _lista; set => _lista = value; }
		public bool SprawdzDaneWejsciowe(string login, string haslo, string imie, string nazwisko, string email)
		{
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(email))
				return false;
			else
				return true;
		}
		public bool SprawdzCzyIstniejeUzytkownik(List<Uwierzytelnianie> daneWejsciowe, string login, string email)
		{
			foreach (var item in daneWejsciowe)
			{
				if (item.Login == login || item.Email == email)
					return false;
			}

			return true;
		}
	}
}
