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
		public void DodajUzytkownika(string login, string haslo, string imie, string nazwisko, string email)
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

		public bool SprawdzDaneLogowania(string login, string haslo)
		{
			Logowanie log = new Logowanie();
			List<Logowanie> listaLoginow;

			//utworzenie obiektu bazy danych
			using (var db = new System.Data.SqlClient.SqlConnection
			(System.Configuration.ConfigurationManager.ConnectionStrings[
				"PolaczenieZBazaDanych"].ConnectionString))
			{
				//otworzenie połączenia z bazą
				//jeśli baza jest wyłączona, lub jej nie ma - wywala wyjątek po stronie klienta
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
							//zczytywanie rekordów podanych w zapytaniu i zapisanie do listy
							listaLoginow.Add(new DTO.Logowanie()
							{
								Login = (string)dr["login_uzytkownika"],
								Haslo = (string)dr["haslo_uzytkownika"],
							});
						}
					}
				}
			}
			//porównanie loginu z text boxów na kliencie z rekordami w bazie
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


	}
}
