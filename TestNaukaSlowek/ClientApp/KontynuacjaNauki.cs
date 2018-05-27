using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class KontynuacjaNauki
    {
        static string SciezkaZapisu = @"C:\testowy\plik4.txt";
        static List<string> Elementy = new List<string>();
        public static void zapis(int Id_SLowka, int WartoscPunktowaOdpowiedzi)
        {
           
            WczytaniePliku();

            bool Test = true;
            for (int i = 0; i < Elementy.Count()-1; i++)
            {
                string[] Podział =Elementy[i].Split(' ');
                
                if( Convert.ToInt32(Podział[0]) == Id_SLowka)
                {
                    int temp = Convert.ToInt32(Podział[1]);
                    temp = temp + WartoscPunktowaOdpowiedzi;
                    Podział[1] = Convert.ToString(temp);
                    Elementy[i] = Podział[0] + " " + Podział[1];
                    Test = false;
                    break;
                }
            }
            if(Test == true)
            {
                Elementy.Add(Id_SLowka + " " + "-1");
            }
            StreamWriter sw = new StreamWriter(SciezkaZapisu);
            for (int i = 0; i < Elementy.Count; i++)
            {
                if (Elementy[i] != null)
                {
                    sw.WriteLine(Elementy[i]);
                }
            }
            sw.Close();
            Elementy.Clear();


        }
        
       
       private static void WczytaniePliku()
        {
            FileStream fs = new FileStream(SciezkaZapisu, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            fs.Close();

            StreamReader sr = new StreamReader(SciezkaZapisu);
            do
            {
            
                Elementy.Add(sr.ReadLine()); 
            } while (Elementy.Last() != null);
            sr.Close();

        }

        public static void KontynuujNauke( ref List<WcfService.Slowka> Slowka)
        {
            WczytaniePliku();
            List<int> Numery = new List<int>();
            List<int> Punkty = new List<int>();

            for (int i = 0; i < Elementy.Count-1; i++)
            {
                string[] Podział = Elementy[i].Split(' ');
                Numery.Add(Convert.ToInt32( Podział[0]));
                Punkty.Add(Convert.ToInt32(Podział[1]));
            }

           for(int k=0; k< Slowka.Count(); k++)
            {
                for(int j=0; j<Numery.Count(); j++)
                {
                    if(Slowka[k].ID == Numery[j] && Punkty[j] < 1)
                    {
                        Slowka.RemoveAt(k);
                        k--;
                        break;
                    }
                }
            }
            Elementy.Clear();
            //for (int i = 0; i < Slowka.Count; i++)
            //{
            //    int temp = Slowka[i].ID;
            //    temp =  Numery.Find(s => s.Equals(temp));
            //    Slowka
            //}

        }
}
}
