﻿using ServerApp.DTO;
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

		public DTO.Slowka LosujSlowkoDoFiszki(string jezyk, string poziom, string kategoria, object token)
		{
			DTO.Slowka slowka = new Slowka
			{
				Jezyk = jezyk,
				Poziom = poziom,
				Kategoria = kategoria
			};
			int indeks;
			List<Slowka> listaSlowek;
			Random losujSlowko = new Random();
			Sesja odswiezanieCzasu = new Sesja();

			using (var db = new System.Data.SqlClient.SqlConnection(
			System.Configuration.ConfigurationManager.ConnectionStrings[
				"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;

					cmd.CommandText =
						"SELECT SLOWKA.SLOWKO, TLUMACZENIA.TLUMACZENIE " +
						"FROM POZIOMY " +
							"INNER JOIN KATEGORIE ON POZIOMY.ID_POZIOMU = KATEGORIE.ID_POZIOMU " +
							"INNER JOIN SLOWKA ON POZIOMY.ID_POZIOMU = SLOWKA.ID_POZIOMU " +
								"AND KATEGORIE.ID_KATEGORII = SLOWKA.ID_KATEGORII " +
							"INNER JOIN JEZYK ON SLOWKA.ID_JEZYKA = JEZYK.ID_JEZYKA " +
							"INNER JOIN TLUMACZENIA ON SLOWKA.ID_TLUMACZENIA = TLUMACZENIA.ID_TLUMACZENIA " +
						"WHERE " +
							"JEZYK.JEZYK = @Jezyk " +
							"AND KATEGORIE.KATEGORIA = @Kategoria " +
							"AND POZIOMY.POZIOM = @Poziom";

					cmd.Parameters.Add("@Jezyk", System.Data.SqlDbType.NVarChar).Value = slowka.Jezyk;
					cmd.Parameters.Add("@Kategoria", System.Data.SqlDbType.NVarChar).Value = slowka.Kategoria;
					cmd.Parameters.Add("@Poziom", System.Data.SqlDbType.NVarChar).Value = slowka.Poziom;

					using (var dr = cmd.ExecuteReader())
					{
						listaSlowek = new List<Slowka>();
						while (dr.Read())
						{
							listaSlowek.Add(new Slowka {
								Slowko = (string)dr["SLOWKO"],
								Tlumaczenie = (string)dr["TLUMACZENIE"]
							});
						}
					}
				}
			}
			if (listaSlowek.Count == 0)
				return slowka;
			
			indeks = losujSlowko.Next(0, listaSlowek.Count - 1);
			slowka.Slowko = listaSlowek[indeks].Slowko;
			slowka.Tlumaczenie = listaSlowek[indeks].Tlumaczenie;

			return slowka;
		}

		public Sesja GenerujToken(string login)
		{
			//Wzór tokenu: XYZ123456
			Sesja sesja = new Sesja
			{
				ListaTokenow = new List<string>()
			};
			Logowanie logowanie = new Logowanie
			{
				Login = login,
				CzyZalogowany = true
			};
			Random rand = new Random();
			char[] slowaTokenu = new char[9];
			int symbol;
			int idTokenu;
			
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
					cmd.CommandText = "SELECT id_uzytkownika FROM Uzytkownicy WHERE login_uzytkownika=@Login";
					cmd.Parameters.Add("@Login", System.Data.SqlDbType.NVarChar).Value = logowanie.Login;
					using (var dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							sesja.IdUzytkownika = (int)dr["id_uzytkownika"];
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

			if (sesja.ListaTokenow != null)
			{
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
			}

			sesja.CzasZalogowania = DateTime.UtcNow;
			sesja.CzasOstatniejAkcji = sesja.CzasZalogowania;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = 
						"INSERT INTO TOKEN_ACCESS(TOKEN, CZAS_LOGOWANIA, CZAS_OSTATNIEJ_AKCJI)" +
						"VALUES(@TOKEN, @CZAS_LOGOWANIA, @CZAS_OSTATNIEJ_AKCJI); " +
						"SELECT SCOPE_IDENTITY()";

					cmd.Parameters.AddWithValue("@TOKEN", sesja.Token);
					cmd.Parameters.AddWithValue("@CZAS_LOGOWANIA", sesja.CzasZalogowania);
					cmd.Parameters.AddWithValue("@CZAS_OSTATNIEJ_AKCJI", sesja.CzasOstatniejAkcji);

					idTokenu = (int)(decimal)cmd.ExecuteScalar();

					cmd.CommandText = 
						"UPDATE Uzytkownicy SET token=@TOKEN, czy_zalogowany=1 " +
						"WHERE id_uzytkownika=@id_uzytkownika";

					cmd.Parameters.AddWithValue("@id_uzytkownika", sesja.IdUzytkownika);
					cmd.Parameters.AddWithValue("@czy_zalogowany", logowanie.CzyZalogowany);
					
					cmd.ExecuteNonQuery();
				}
			}

			return sesja;
		}

		public DTO.FormyNauki RozpocznijNauke(string formaNauki, string jezyk, string poziom, object token)
		{
			FormyNauki formyNauki = new FormyNauki
			{
				FormaNauki = formaNauki,
				Jezyk = jezyk,
				Poziom = poziom
			};

			using (var db = new System.Data.SqlClient.SqlConnection(
			System.Configuration.ConfigurationManager.ConnectionStrings[
				"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT FORMY_NAUKI.FORMA_NAUKI, POZIOMY.POZIOM, JEZYK.JEZYK " +
						"FROM FORMY_NAUKI " +
						"INNER JOIN POSTEP " +
						"ON FORMY_NAUKI.ID_FORMY = POSTEP.ID_FORMY " +
						"INNER JOIN POZIOMY " +
						"ON POSTEP.ID_POZIOMU = POZIOMY.ID_POZIOMU " +
						"INNER JOIN JEZYK ON POSTEP.ID_JEZYKA = JEZYK.ID_JEZYKA";

					cmd.Parameters.Add("@FormaNauki", System.Data.SqlDbType.NVarChar).Value = formyNauki.FormaNauki;
					cmd.Parameters.Add("@Poziom", System.Data.SqlDbType.NVarChar).Value = formyNauki.Poziom;
					cmd.Parameters.Add("@Jezyk", System.Data.SqlDbType.NVarChar).Value = formyNauki.Jezyk;
				}
			}

			return formyNauki;
		}

		public List<Slowka> PobierzKategorie(string poziom, object token)
		{
			List<Slowka> listaKategorii = new List<Slowka>();
			
			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = 
						"SELECT KATEGORIE.KATEGORIA " +
						"FROM KATEGORIE " +
						"INNER JOIN POZIOMY ON KATEGORIE.ID_POZIOMU = POZIOMY.ID_POZIOMU " +
						"WHERE POZIOMY.POZIOM = @Poziom";

					cmd.Parameters.Add("@Poziom", System.Data.SqlDbType.NVarChar).Value = poziom;

					using (var dr = cmd.ExecuteReader())
					{
						while (dr.Read())
						{
							listaKategorii.Add(new Slowka
							{
								Kategoria = (string)dr["KATEGORIA"]
							});
						}
					}
				}
			}

			return listaKategorii;
		}

		public void AktualizujAktywnoscUzytkownika(object token)
		{
			Sesja obiektSesji = new Sesja
			{
				CzasOstatniejAkcji = DateTime.UtcNow,
				Token = token.ToString()
			};

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = 
						"UPDATE TOKEN_ACCESS " +
						"SET CZAS_OSTATNIEJ_AKCJI=@CzasOstatniejAkcji " +
						"WHERE TOKEN=@Token";

					cmd.Parameters.Add("@CzasOstatniejAkcji",System.Data.SqlDbType.DateTime).Value=obiektSesji.CzasOstatniejAkcji;
					cmd.Parameters.Add("@Token", System.Data.SqlDbType.NVarChar).Value = obiektSesji.Token;
					cmd.ExecuteNonQuery();
				}
			}
		}

		public void WylogowanieUzytkownika(object token)
		{
			Sesja obiektSesji = new Sesja
			{
				CzasOstatniejAkcji = DateTime.UtcNow,
				Token = token.ToString(),
			};
			Logowanie logowanie = new Logowanie
			{
				CzyZalogowany = false,
			};

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText =
						"UPDATE Uzytkownicy SET czy_zalogowany=0 " +
						"SET czy_zalogowany=@CzasOstatniejAkcji " +
						"WHERE TOKEN=@Token";

					cmd.Parameters.Add("@CzasOstatniejAkcji", System.Data.SqlDbType.DateTime).Value = obiektSesji.CzasOstatniejAkcji;
					cmd.Parameters.Add("@Token", System.Data.SqlDbType.NVarChar).Value = obiektSesji.Token;
					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}