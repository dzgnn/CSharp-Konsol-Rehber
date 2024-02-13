using System;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    class Calisan {
        private static int calisansayisi;

        
        public static int Calisansayisi1 { get => calisansayisi; set => calisansayisi = value; }

        private string Ad;
        private string Soyisim;
        private string Departman;

        static Calisan(){

            Calisansayisi1 = 0;

        }

        
        public Calisan(string soyisim, string departman, string ad){

            this.Ad = ad;
            this.Soyisim = soyisim;
            this.Departman = departman;
            Calisansayisi1 ++;

        }


    }
}