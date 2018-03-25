using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public class ObslugaLogowania
	{
		private WcfService.Logowanie _login;
		public WcfService.Logowanie Login { get => _login; set => _login = value; }
	}
}
