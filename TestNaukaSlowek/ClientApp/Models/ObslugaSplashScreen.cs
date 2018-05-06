using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public static class ObslugaSplashScreen
	{
		public static bool CzySplashOdpalony { get { return _czySplashOdpalony; } set { _czySplashOdpalony = value; } }
		private static bool _czySplashOdpalony = false;
	}
}
