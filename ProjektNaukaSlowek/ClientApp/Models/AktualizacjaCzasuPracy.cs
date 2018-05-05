using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public static class AktualizacjaCzasuPracy
	{
		public static async void AktualizujSesjeUzytkownika()
		{
			using (var client = new WcfService.Service1Client())
			{
				await client.AktualizujAktywnoscUzytkownikaAsync(Models.Token.NumerToken);
			}
		}
	}
}
