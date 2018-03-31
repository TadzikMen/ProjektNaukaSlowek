using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class Logowanie
	{
		[DataMember]
		public string Login { get; set; }
		[DataMember]
		public string Haslo { get; set; }
		[DataMember]
		public bool CzyZalogowany { get; set; }
	}
}