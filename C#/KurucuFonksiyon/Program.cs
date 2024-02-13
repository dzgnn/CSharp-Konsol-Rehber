using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            Console.WriteLine("--- 1. Çalışan ---");
            calisan1.adi = "Emirhan";
            calisan1.soyadi = "Düzgün";
            calisan1.no = "1234123";
            calisan1.CalisanBilgileri();

            Console.WriteLine("--- 2. Çalışan ---");
            Calisan calisan2 = new Calisan("erdem","düz","55");
            calisan2.CalisanBilgileri();

            Console.WriteLine("--- 3. Çalışan ---");
            Calisan calisan3 = new Calisan("Efe","DZGN");
            calisan3.CalisanBilgileri();

        }
    }

    class Calisan
    {
        public string adi;
        public string soyadi;
        public string no;

        public Calisan(string ad, string soyad, string noo)
        {
           this.adi = ad;
           this.soyadi = soyad;
           this.no = noo;    
        }
        public Calisan(string ad, string soyad)
        {
           this.adi = ad;
           this.soyadi = soyad;
           
        }

        public Calisan(){}

        public void CalisanBilgileri(){

            Console.WriteLine(adi);
            Console.WriteLine(soyadi);
            Console.WriteLine(no);
        }        


    }
}