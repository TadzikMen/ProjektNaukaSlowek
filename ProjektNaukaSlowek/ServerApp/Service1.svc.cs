using ServerApp.DTO;
using System;
using System.Collections.Generic;

namespace ServerApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}

        public void DodajUzytkownika(string login, string haslo, string email, string imie = null, string nazwisko = null)
		{
			DTO.Rejestracja uzytkownik = new Rejestracja();
			int Id;

			uzytkownik.Login = login;
            uzytkownik.Haslo = Hashing.HashPassword(haslo);
			uzytkownik.Imie = imie;
			uzytkownik.Nazwisko = nazwisko;
			uzytkownik.Email = email;
			uzytkownik.CzyZalogowany = false;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "INSERT INTO Uzytkownicy(" +
						"login_uzytkownika, haslo_uzytkownika, imie_uzytkownika, nazwisko_uzytkownika, email_uzytkownika, czy_zalogowany) " +
						"VALUES(@Login, @Haslo, @Imie, @Nazwisko, @Email, @CzyZalogowany);" +
						"SELECT SCOPE_IDENTITY();";

					cmd.Parameters.AddWithValue("@Login", uzytkownik.Login);
					cmd.Parameters.AddWithValue("@Haslo", uzytkownik.Haslo);
					cmd.Parameters.AddWithValue("@Imie", uzytkownik.Imie);
					cmd.Parameters.AddWithValue("@Nazwisko", uzytkownik.Nazwisko);
					cmd.Parameters.AddWithValue("@Email", uzytkownik.Email);
					cmd.Parameters.AddWithValue("@CzyZalogowany", uzytkownik.CzyZalogowany);

					Id = (int)(decimal)cmd.ExecuteScalar();
				}
			}
		}
		
		public bool SprawdzDaneLogowania(string login, string haslo)
		{
			Logowanie log = new Logowanie();
			List<Logowanie> listaLoginow;

			using (var db = new System.Data.SqlClient.SqlConnection
			(System.Configuration.ConfigurationManager.ConnectionStrings[
				"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT login_uzytkownika, haslo_uzytkownika FROM Uzytkownicy";

					using (var dr = cmd.ExecuteReader())
					{
						listaLoginow = new List<Logowanie>();
						while (dr.Read())
						{
							listaLoginow.Add(new DTO.Logowanie()
							{
								Login = (string)dr["login_uzytkownika"],
								Haslo = (string)dr["haslo_uzytkownika"],
							});
						}
					}
				}
			}

			foreach (var item in listaLoginow)
			{
                //	if (item.Login == login && item.Haslo == haslo)
                if (item.Login == login && Hashing.ValidatePassword(haslo, item.Haslo) == true)
                {
					log.Login = login;
					log.Haslo = haslo;
					return true;
				}
			}

			return false;
		}

		public List<DTO.Uwierzytelnianie> PobierzLoginyMaileImiona()
		{
			List<Uwierzytelnianie> listaLoginowMailiImion;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT login_uzytkownika, email_uzytkownika, imie_uzytkownika FROM Uzytkownicy";

					using (var dr = cmd.ExecuteReader())
					{
						listaLoginowMailiImion = new List<Uwierzytelnianie>();
						while (dr.Read())
						{
							listaLoginowMailiImion.Add(new Uwierzytelnianie
							{
								Login = (string)dr["login_uzytkownika"],
								Email = (string)dr["email_uzytkownika"],
								Imie = (string)dr["imie_uzytkownika"]
							});
						}
					}
				}
			}

			return listaLoginowMailiImion;
		}

		public void WyslijMailaRejestracja(string login, string haslo, string email, string imie = null, string nazwisko = null)
		{
			string _wiadomosc;
			WysylanieMaila mail = new WysylanieMaila(email);

			if (String.IsNullOrEmpty(imie))
				_wiadomosc = $"Dziękujemy za rejestrację w serwisie Nauka Słówek, {login}!\nTwoje hasło dostępu to: {haslo}";
			else
				_wiadomosc = $"Dziękujemy za rejestrację w serwisie Nauka Słówek, {imie} {nazwisko}!\nTwoje hasło dostępu to {haslo}";


			System.Net.Mail.MailMessage mailMess = new System.Net.Mail.MailMessage(
				"naukaslowek.adm@gmail.com",
				email,
				"Witamy w Serwisie Nauka Słówek!",
				_wiadomosc
				);
			System.Net.NetworkCredential netCred = new System.Net.NetworkCredential("naukaslowek.adm@gmail.com", "diagrama");
			System.Net.Mail.SmtpClient smtpobj = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
			{
				EnableSsl = true,
				Credentials = netCred
			};
			smtpobj.Send(mailMess);
		}

		public Logowanie PrzekazDaneDoZalogowania(string login)
		{
			Logowanie zalogowanyUzytkownik = new Logowanie
			{
				Login = login
			};

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT login_uzytkownika FROM Uzytkownicy WHERE login_uzytkownika = @Login";
					cmd.Parameters.Add("nazwa_uzytkownika", System.Data.SqlDbType.NVarChar).Value = zalogowanyUzytkownik.Login;
				}
			}

			return zalogowanyUzytkownik;
		}

		public FormyNauki RozpocznijNauke(string formaNauki, string jezyk, string poziom)
		{
			throw new NotImplementedException();
		}

		public Slowka ZwrocTlumaczenieSlowka(string slowo)
		{
			DTO.Slowka slowka = new Slowka
			{
				WprowadzoneSlowo = slowo
			};


			return slowka;
		}

		public Sesja GenerujToken()
		{
			//Wzór tokenu: XYZ123456
			Sesja sesja = new Sesja();
			Random rand = new Random();
			char[] slowaTokenu = new char[9];
			int symbol;
			int id;
			
			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT TOKEN FROM TOKEN_ACCESS";
					using (var dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							sesja.ListaTokenow.Add( 
								(string)dr["TOKEN"]
							);
						}
					}
				}
			}

			for (int i = 0; i < 9; i++)
			{
				if (i < 3)
				{
					symbol = rand.Next(65, 90);
					slowaTokenu[i] = (char)symbol;
				}
				else
				{
					symbol = rand.Next(48, 57);
					slowaTokenu[i] = (char)symbol;
				}
			}

			foreach (var item in slowaTokenu)
				sesja.Token += item;

			while (sesja.ListaTokenow.Contains(sesja.Token))
			{
				for (int i = 0; i < 9; i++)
				{
					if (i < 3)
					{
						symbol = rand.Next(65, 90);
						slowaTokenu[i] = (char)symbol;
					}
					else
					{
						symbol = rand.Next(48, 57);
						slowaTokenu[i] = (char)symbol;
					}
				}
			}

			sesja.CzasZalogowania = DateTime.Now;
			sesja.CzasOstatniejAkcji = DateTime.Now;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "INSERT INTO TOKEN_ACCESS(ID_UZYTKOWNIKA, TOKEN, CZAS_LOGOWANIA, CZAS_OSTATNIEJ_AKCJI)" +
						"VALUES(@ID_UZYTKOWNIKA, @TOKEN, @CZAS_LOGOWANIA, @CZAS_OSTATNIEJ_AKCJI); SELECT SCOPE_IDENTITY()";
					cmd.Parameters.AddWithValue("@ID_UZYTKOWNIKA", sesja.IdUzytkownika);
					cmd.Parameters.AddWithValue("@TOKEN", sesja.Token);
					cmd.Parameters.AddWithValue("@CZAS_LOGOWANIA", sesja.CzasZalogowania);
					cmd.Parameters.AddWithValue("@CZAS_OSTATNIEJ_AKCJI", sesja.CzasOstatniejAkcji);

					id = (int)(decimal)cmd.ExecuteScalar();
				}
			}

			return sesja;
		}
	}
}