using ServerApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

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
			uzytkownik.Haslo = haslo;
			uzytkownik.Imie = imie;
			uzytkownik.Nazwisko = nazwisko;
			uzytkownik.Email = email;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "INSERT INTO Uzytkownicy(login_uzytkownika, haslo_uzytkownika, imie_uzytkownika, nazwisko_uzytkownika, email_uzytkownika) " +
						"VALUES(@Login, @Haslo, @Imie, @Nazwisko, @Email);" +
						"SELECT SCOPE_IDENTITY();";

					cmd.Parameters.AddWithValue("@Login", uzytkownik.Login);
					cmd.Parameters.AddWithValue("@Haslo", uzytkownik.Haslo);
					cmd.Parameters.AddWithValue("@Imie", uzytkownik.Imie);
					cmd.Parameters.AddWithValue("@Nazwisko", uzytkownik.Nazwisko);
					cmd.Parameters.AddWithValue("@Email", uzytkownik.Email);

					Id = (int)(decimal)cmd.ExecuteScalar();
				}
			}
		}
        public void DodajSlowka(string jezyk, string slowko, string tlumaczenie, string kategoria)
        {
            DTO.Zarzadzaj slowka = new Zarzadzaj();
            int Id;

            slowka.jezyk = jezyk;
            slowka.slowko = slowko;
            slowka.tlumaczenie = tlumaczenie;
            slowka.kategoria = kategoria;
           

            using (var db = new System.Data.SqlClient.SqlConnection(
                System.Configuration.ConfigurationManager.ConnectionStrings[
                    "PolaczenieZBazaDanych"].ConnectionString))
            {
                db.Open();
                using (var cmd = new System.Data.SqlClient.SqlCommand())
                {
                    cmd.Connection = db;
                    cmd.CommandText = "INSERT INTO SLOWKA(JEZYK, SLOWKO, TLUMACZENIE, KATEGORIA) " +
                        "VALUES(@jezyk, @slowko, @tlumaczenie, @kategoria);" +
                        "SELECT SCOPE_IDENTITY();";

                    cmd.Parameters.AddWithValue("@Login", slowka.jezyk);
                    cmd.Parameters.AddWithValue("@Haslo", slowka.slowko);
                    cmd.Parameters.AddWithValue("@Imie", slowka.tlumaczenie);

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
					cmd.CommandText = "SELECT * FROM Uzytkownicy";

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
				if (item.Login == login && item.Haslo == haslo)
				{
					log.Login = login;
					log.Haslo = haslo;
					return true;
				}
			}

			return false;
		}

		public List<DTO.Uwierzytelnianie> PobierzLoginyIMaile()
		{
			List<Uwierzytelnianie> listaLoginowMaili;

			using (var db = new System.Data.SqlClient.SqlConnection(
				System.Configuration.ConfigurationManager.ConnectionStrings[
					"PolaczenieZBazaDanych"].ConnectionString))
			{
				db.Open();
				using (var cmd = new System.Data.SqlClient.SqlCommand())
				{
					cmd.Connection = db;
					cmd.CommandText = "SELECT login_uzytkownika, email_uzytkownika FROM Uzytkownicy";

					using (var dr = cmd.ExecuteReader())
					{
						listaLoginowMaili = new List<Uwierzytelnianie>();
						while (dr.Read())
						{
							listaLoginowMaili.Add(new Uwierzytelnianie
							{
								Login = (string)dr["login_uzytkownika"],
								Email = (string)dr["email_uzytkownika"]
							});
						}
					}
				}
			}

			return listaLoginowMaili;
		}

		public void WyslijMailaRejestracja(string login, string haslo, string email, string imie = null, string nazwisko=null)
		{
			string _wiadomosc;
			WysylanieMaila mail = new WysylanieMaila(email);
			
			if (String.IsNullOrEmpty(imie))
				_wiadomosc = $"Dziękujemy za rejestrację w serwisie Nauka Słówek, {login}!\n Twoje hasło dostępu to: {haslo}";
			else
				_wiadomosc = $"Dziękujemy za rejestrację w serwisie Nauka Słówek, {imie} {nazwisko}!\n Twoje hasło dostępu to {haslo}";


			System.Net.Mail.MailMessage mailMess = new System.Net.Mail.MailMessage(
				"naukaslowek.adm@gmail.com",
				email,
				"Witamy w Serwisie Nauka Słówek!",
				_wiadomosc
				);
			System.Net.NetworkCredential netCred = new System.Net.NetworkCredential("naukaslowek.adm@gmail.com", "diagrama");
			System.Net.Mail.SmtpClient smtpobj = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
			smtpobj.EnableSsl = true;
			smtpobj.Credentials = netCred;
			smtpobj.Send(mailMess);			
		}
	}
}
