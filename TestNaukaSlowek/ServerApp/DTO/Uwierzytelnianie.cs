using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class Uwierzytelnianie
	{
		[DataMember]
		public string Login { get; set; }
		[DataMember]
		public string Email { get; set; }
		[DataMember]
		public string Imie { get; set; }
	}
}