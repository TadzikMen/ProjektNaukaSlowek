using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerApp.DTO
{
	[DataContract]
	public class Slowka
	{
		[DataMember]
		public string Jezyk { get; set; }
		[DataMember]
		public string Slowko { get; set; }
		[DataMember]
		public string Kategoria { get; set; }
		[DataMember]
		public string Poziom { get; set; }
		[DataMember]
		public string Tlumaczenie { get; set; }


	}
}