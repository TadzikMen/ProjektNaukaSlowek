using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class KontynuacjaNauki
    {
        void zapis(int ID_SLowka)
        {
            if (!File.Exists(@"C:\plik4.txt"))
            {
                File.Create(@"C:\plik4.txt");
            }
            FileStream fs = new FileStream(@"D:\plik4.txt", FileMode.Open, FileAccess.ReadWrite);
            

            fs.Close();
        }
        
        void odczyt()
        {
            if (!File.Exists(@"C:\plik4.txt"))
            {
                File.Create(@"C:\plik4.txt");
            }
            FileStream fs = new FileStream(@"D:\plik4.txt", FileMode.Open, FileAccess.Read);



            fs.Close();
        }
}
}
