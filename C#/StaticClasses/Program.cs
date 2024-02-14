using System;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

//     class Ogrenci {
//     public static int OgrenciSayisi = 0;
//     public string Isim;
//     public string Soyisim;
//     public Ogrenci() {
//         OgrenciSayisi++;
//     }
// }

// class Program {
//     static void Main(string[] args) {
//         //Static sınıf üyesine erişim
//         Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);

//         //Static olmayan sinif üyesine erişim
//         Ogrenci ogrenci1 = new Ogrenci();
//         ogrenci1.Isim = "Deniz";
//         ogrenci1.Soyisim = "Arda";
        
//         Ogrenci ogrenci2 = new Ogrenci();
//         ogrenci2.Isim = "Ayşe";
//         ogrenci2.Soyisim = "Yılmaz";

//         Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
//     }
// }
        
    static void Main(string[] args)
        {
            Console.WriteLine(Calisan.Calisansayisi);
           
            Calisan calisan1 = new Calisan("Emirhan","Düzgün","C#");
            Console.WriteLine(Calisan.Calisansayisi);

            Calisan calisan2 = new Calisan("Erdem","Düzgün","anao");
            Calisan calisan3 = new Calisan("Efe","Düzgün","şef");

            Console.WriteLine(Calisan.Calisansayisi);

            var sonuc = Islemler.Topla(100,200);
            Console.WriteLine(sonuc);

            Console.WriteLine("Çarpmanin sonucu = {0}", Islemler.Carp(5,2));
        }
    }

    class Calisan {
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi; set => calisansayisi = value; }

        private string Ad;
        private string Soyisim;
        private string Departman;

        static Calisan(){
            Calisansayisi = 0;
        }

        public Calisan(string soyisim, string departman, string ad){

            this.Ad = ad;
            this.Soyisim = soyisim;
            this.Departman = departman;
            Calisansayisi ++;

        }
    }
    static class Islemler{
        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1 + sayi2;

        }
        public static long Carp (int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}