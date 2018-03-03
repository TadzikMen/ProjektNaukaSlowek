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
	}
}
