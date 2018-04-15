using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class Sesja
	{
		[DataMember]
		public string Token { get; set; }
		[DataMember]
		public int IdUzytkownika { get; set; }
		[DataMember]
		public string PobraneTokeny { get; set; }
	}
}