using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public static class Sesja
	{
		[DataMember]
		public static string IdUzytkownika { get; set; }
		[DataMember]
		public static string HasloUzytkownika { get; set; }
	}
}