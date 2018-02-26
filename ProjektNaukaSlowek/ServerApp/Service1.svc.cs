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
			string tekst;
			string login2 = "";
			string haslo2="";
			int dlugosc, l = 0;
			char spacja;
			System.IO.StreamReader sr = new System.IO.StreamReader("baza.txt");
			tekst = sr.ReadLine();
			dlugosc = tekst.Length;

			for (int i = 0; i < dlugosc; i++)
			{
				spacja = Convert.ToChar(tekst[i]);
				if (spacja == 32)
				{
					if (l > 0)
						i = dlugosc;
					l++;
				}
				if (l == 0)
					login2 += tekst[i];
				else if (i != dlugosc && spacja != 32)
					haslo2 += tekst[i];

			}

			if (login == login2 && haslo == haslo2)
			{
				return true;
			}
			else
				return false;
		}
	}
}
