using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
	public class ObslugaFormatek
	{
		private static Aplikacja _frmAplikacja = new Aplikacja();
		private static EdycjaUseraAdmina _frmEdycjaUseraAdmina = new EdycjaUseraAdmina();
		private static KontynuujNauke _frmKontynuujNauke = new KontynuujNauke();
		private static Logowanie _frmLogowanie = new Logowanie();
		private static MenuGlowne _frmMenuGlowne = new MenuGlowne();
		private static PrzypomnienieHasla _frmPrzypomnienieHasla = new PrzypomnienieHasla();
		private static Rejestracja _frmRejestracja = new Rejestracja();
		private static SprawdzSwojePostepy _frmSprawdzSwojePostepy = new SprawdzSwojePostepy();
		private static WeryfikacjaKodu _frmWeryfikacjaKodu = new WeryfikacjaKodu();
		private static Zarzadzaj _frmZarzadzaj = new Zarzadzaj();
		private static ZobaczSwojeOsiagniecia _frmZobaczSwojeOsiagniecia = new ZobaczSwojeOsiagniecia();

		public static Aplikacja FrmAplikacja { get { return _frmAplikacja; } }
		public static EdycjaUseraAdmina FrmEdycjaUseraAdmina { get { return _frmEdycjaUseraAdmina; } }
		public static KontynuujNauke FrmKontynuujNauke { get { return _frmKontynuujNauke; } }
		public static Logowanie FrmLogowanie { get { return _frmLogowanie; } }
		public static MenuGlowne FrmMenuGlowne { get { return _frmMenuGlowne; } }
		public static PrzypomnienieHasla FrmPrzypomnienieHasla { get { return _frmPrzypomnienieHasla; } }
		public static Rejestracja FrmRejestracja { get { return _frmRejestracja; } }
		public static SprawdzSwojePostepy FrmSprawdzSwojePostepy { get { return _frmSprawdzSwojePostepy; } }
		public static WeryfikacjaKodu FrmWeryfikacjaKodu { get { return _frmWeryfikacjaKodu; } }
		public static Zarzadzaj FrmZarzadzaj { get { return _frmZarzadzaj; } }
		public static ZobaczSwojeOsiagniecia FrmZobaczSwojeOsiagniecia { get { return _frmZobaczSwojeOsiagniecia; } }
	}
}
