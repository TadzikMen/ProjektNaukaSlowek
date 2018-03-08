using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerApp.DTO
{
	[DataContract]
	public class Rejestracja
	{
		[DataMember]
		public string Login { get; set; }
		[DataMember]
		public string Haslo { get; set; }
		[DataMember]
		public string Imie { get; set; }
		[DataMember]
		public string Nazwisko { get; set; }
		[DataMember]
		public string Email { get; set; }
	}
}