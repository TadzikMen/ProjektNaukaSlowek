using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    public class ObslugaLogowania
    {
        private WcfService.Logowanie _daneLogowania;
        public WcfService.Logowanie DaneLogowania
        {
            get
            {
                return _daneLogowania;
            }

            set
            {
                _daneLogowania = value;
            }
        }
    }
}
