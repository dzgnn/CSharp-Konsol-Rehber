using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazartesi);

            int sicaklik = 32;

            if (sicaklik <= (int)havadurumu.normal){
                Console.WriteLine("Hava soğuk");
            }
            else if (sicaklik >= (int)havadurumu.sicak){
                Console.WriteLine("hava sıcak");
            }
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi = 9,
        Pazar
    }
    
    enum havadurumu {

        soguk = 5,
        normal = 20,
        sicak = 25,
        coksicak = 30





    }
}