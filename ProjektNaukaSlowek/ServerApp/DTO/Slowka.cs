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
		public string TlumaczenieSlowka { get; set; }
		[DataMember]
		public string WprowadzoneSlowo { get; set; }
	}
}