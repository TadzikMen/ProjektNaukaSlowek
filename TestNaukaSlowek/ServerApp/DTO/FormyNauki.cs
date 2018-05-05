using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ServerApp.DTO
{
	[DataContract]
	public class FormyNauki
	{
		[DataMember]
		public string FormaNauki { get; set; }
		[DataMember]
		public string Jezyk { get; set; }
		[DataMember]
		public string Poziom { get; set; }
	}
}