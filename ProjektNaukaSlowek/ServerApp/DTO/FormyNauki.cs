using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ServerApp.DTO
{
	[DataContract]
	public class FormyNauki
	{
		[DataMember]
		public string FormaNauki { get; set; }
		[DataMember]
		public string WybranyJezyk { get; set; }
		[DataMember]
		public string Poziom { get; set; }
	}
}