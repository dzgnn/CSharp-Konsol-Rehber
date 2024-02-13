using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Emirhan";
            ogrenci1.Soyisim = "Düzgün";
            ogrenci1.OgrNo = 17;
            ogrenci1.Sinif = 10;
            ogrenci1.BilgileriGetir();
            ogrenci1.sinifatlat();
            ogrenci1.BilgileriGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrNo { get => ogrNo; set => ogrNo = value; }
        public int Sinif { get => sinif; set => sinif = value; }

        public Ogrenci()
        {
           
        }
        public Ogrenci(string soyisim, int ogrNo, int sinif, string isim)
        {
            Soyisim = soyisim;
            OgrNo = ogrNo;
            Sinif = sinif;
            Isim = isim;
        }

        public void BilgileriGetir(){

            Console.WriteLine("Öğrenci bilgileri");
            Console.WriteLine("Öğrenci Adi : {0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadi : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci Sinifi : {0}", this.Sinif);
            Console.WriteLine("Öğrenci Nosu : {0}", this.OgrNo);
        }

        public void sinifatlat(){

            this.Sinif = this.Sinif + 1;
        }
    }
}