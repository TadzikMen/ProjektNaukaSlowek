using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class Rejestracja : Logowanie
	{
		[DataMember]
		public string Imie { get; set; }
		[DataMember]
		public string Nazwisko { get; set; }
		[DataMember]
		public string Email { get; set; }
		[DataMember]
		public bool CzyAdmin { get; set; }
	}
}