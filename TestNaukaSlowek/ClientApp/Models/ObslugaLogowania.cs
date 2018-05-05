using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.WcfService;

namespace ClientApp.Models
{
	public class ObslugaLogowania
	{
		private WcfService.Logowanie _daneLogowania;
		private WcfService.Uwierzytelnianie _listaDoPrzekazaniaWLogowaniu;
		
		public List<WcfService.Uwierzytelnianie> ListaUserow { get; set; }
		public Logowanie DaneLogowania { get => _daneLogowania; set => _daneLogowania = value; }
	}
}
