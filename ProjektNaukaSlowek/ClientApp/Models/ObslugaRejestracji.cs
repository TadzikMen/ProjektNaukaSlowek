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
		public ObslugaRejestracji(string login, string haslo, string haslo2, string email, string imie = null, string nazwisko = null)
		{
			this.Login = login;
			this.Haslo = haslo;
            this.Haslo2 = haslo2;
            this.Email = email;
			this.Imie = imie;
			this.Nazwisko = nazwisko;
		}

		public string Login { get; set; }
		public string Haslo { get; set; }
        public string Haslo2 { get; set; }
        public string Email { get; set; }
		public string Imie { get; set; }
		public string Nazwisko { get; set; }

		private List<WcfService.Uwierzytelnianie> _lista;
		public List<Uwierzytelnianie> Lista
        {
            get
            {
                return _lista;
            }

            set
            {
                _lista = value;
            }
        }
		public bool SprawdzDaneWejsciowe(string login, string haslo, string haslo2, string email)
		{
			if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo) || string.IsNullOrEmpty(haslo2) || string.IsNullOrEmpty(email))
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
