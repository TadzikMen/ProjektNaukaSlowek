using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

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
        public int ID { get; set; }
        [DataMember]
		public string Kategoria { get; set; }
		[DataMember]
		public string Poziom { get; set; }
		[DataMember]
		public string Tlumaczenie { get; set; }
	}
}