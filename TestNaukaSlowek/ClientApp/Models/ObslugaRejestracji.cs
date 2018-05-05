using ClientApp.WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public List<Uwierzytelnianie> Lista { get => _lista; set => _lista = value; }

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

		public bool WalidacjaHasla(string haslo, string powtorzoneHaslo)
		{
			if (haslo.Length < 8)
				return false;

			if (haslo.Any(c => char.IsUpper(c)) && haslo.Any(c => char.IsDigit(c)))
				return true;
				
			else
				return false;
		}

		public bool SprawdzenieEmail(string email)
		{
			//(@) Dopasowanie znaku @. Jest to pierwsza grupa przechwytywania.
			//(.+) Odpowiada jedno lub więcej wystąpień dowolnego znaku. Jest to druga grupa przechwytywania.
			//$	Zakończenie dopasowuje koniec ciągu.

			// Przykładowe interpretacje funkcji:
			//       Poprawne: prezes.jarosław@straszydlo.com
			//       Poprawne: d.j@server1.prokotlet.com
			//       Poprawne: antoni@do1.broni.com
			//       Niepoprawne: j.@ry.dzyk.com
			//       Poprawne: j@proseware.com9
			//       Poprawne: js#internal@proseware.com
			//       Poprawne: j_9@[129.666.118.1]
			//       Niepoprawne: j..s@proseware.com
			//       Niepoprawne: js*@proseware.com
			//       Niepoprawne: js@proseware..com
			//       Poprawne: js@proseware.com9
			//       Poprawne: j.s@server1.proseware.com

			if (string.IsNullOrEmpty(email))
				return false;

			else if (System.Text.RegularExpressions.Regex.IsMatch(
				email,
				@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
				@"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
				System.Text.RegularExpressions.RegexOptions.IgnoreCase)
				)
				return true;
			else
				return false;
		}

		public bool SprawdzenieImieINazwisko(string imie, string nazwisko)
		{
			if (imie == string.Empty || nazwisko == string.Empty)
				return true;

			else if (!char.IsUpper(imie, 0) || !char.IsUpper(nazwisko, 0))
				return false;

			else
				return true;
		}
	}
}
