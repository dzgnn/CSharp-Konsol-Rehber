using System;
using System.ComponentModel;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.adi = "Emirhan";
            calisan1.soyadi = "Düzgün";
            calisan1.no = "1234123";
            calisan1.CalisanBilgileri();

        }
    }

    public class Calisan
    {
        public string adi;
        public string soyadi;
        public string no;
        public void CalisanBilgileri(){

            Console.WriteLine(adi);
            Console.WriteLine(soyadi);
            Console.WriteLine(no);
        }        


    }
}