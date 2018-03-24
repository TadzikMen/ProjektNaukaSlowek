using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class WysylanieMaila : Rejestracja
	{
		private string _wiadomosc;
		private string _email;
		private string _imie;

		public WysylanieMaila(string email)
		{
			this._imie = Imie;
			this._email = Email;
		}
	}
}