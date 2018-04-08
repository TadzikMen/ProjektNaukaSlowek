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
		public List<int> IdUzytkownika { get; set; }
	}
}